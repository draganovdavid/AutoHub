using AutoHub.Application.Common.Interfaces;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using static AutoHub.Domain.Constants.Listings.ListingConstants;
using static AutoHub.Domain.Constants.Vehicles.CarConstants;
using static AutoHub.Domain.Constants.Vehicles.VehicleTypeConstants;

namespace AutoHub.Application.Listings.Commands.CreateCarListing
{
    public class CreateCarListingCommandValidator : AbstractValidator<CreateCarListingCommand>
    {
        private readonly IApplicationDbContext _context;

        public CreateCarListingCommandValidator(IApplicationDbContext context)
        {
            _context = context;

            RuleFor(x => x.Title)
                .NotEmpty()
                .MaximumLength(TitleMaxLength);

            RuleFor(x => x.Description)
                .MaximumLength(DescriptionMaxLength);

            RuleFor(x => x.PhoneNumber)
                .NotEmpty()
                .MaximumLength(PhoneNumberMaxLength);

            RuleFor(x => x.Price)
                .NotNull()
                .When(x => !x.IsPriceOnRequest)
                .WithMessage("Price is required unless the listing is price-on-request.");

            RuleFor(x => x.Price)
                .GreaterThan(0)
                .When(x => !x.IsPriceOnRequest && x.Price.HasValue)
                .WithMessage("Price must be greater than 0.");

            RuleFor(x => x.Price)
                .Null()
                .When(x => x.IsPriceOnRequest)
                .WithMessage("Price must be empty when the listing is price-on-request.");

            //RuleFor(x => x.Price)
            //    .Must(price => price.HasValue && price > 0)
            //    .When(x => !x.IsPriceOnRequest)
            //    .WithMessage("Price is required and must be greater than 0 unless the listing is price-on-request.");

            //RuleFor(x => x.Price)
            //    .Null()
            //    .When(x => x.IsPriceOnRequest)
            //    .WithMessage("Price must be empty when the listing is price-on-request.");

            RuleFor(x => x.ProductionYear)
                .InclusiveBetween(1900, DateTime.UtcNow.Year + 1);

            RuleFor(x => x.Mileage)
                .GreaterThanOrEqualTo(0);

            RuleFor(x => x.Horsepower)
                .GreaterThan(0);

            RuleFor(x => x.VinNumber)
                .MaximumLength(VinNumberMaxLength);

            RuleFor(x => x.LocationId)
                .MustAsync((id, ct) => _context.Locations.AnyAsync(l => l.Id == id, ct))
                .WithMessage("Selected location does not exist.");

            RuleFor(x => x)
                .MustAsync(VehicleModelBelongsToBrandAsync)
                .WithMessage("Selected model does not belong to the selected brand.");

            RuleFor(x => x.EngineTypeId)
                .MustAsync((id, ct) => _context.EngineTypes.AnyAsync(e => e.Id == id, ct))
                .WithMessage("Selected engine type does not exist.");

            RuleFor(x => x.TransmissionId)
                .MustAsync((id, ct) => _context.Transmissions.AnyAsync(t => t.Id == id, ct))
                .WithMessage("Selected transmission does not exist.");

            RuleFor(x => x.EuroStandardId)
                .MustAsync((id, ct) => _context.EuroStandards.AnyAsync(e => e.Id == id, ct))
                .WithMessage("Selected euro standard does not exist.");

            RuleFor(x => x.ColorId)
                .MustAsync((id, ct) => _context.Colors.AnyAsync(c => c.Id == id, ct))
                .WithMessage("Selected color does not exist.");

            RuleFor(x => x.BodyTypeId)
                .MustAsync((id, ct) => _context.BodyTypes.AnyAsync(b => b.Id == id, ct))
                .WithMessage("Selected body type does not exist.");

            RuleFor(x => x.SelectedFeatureIds)
                .NotNull()
                .WithMessage("SelectedFeatureIds must be provided (send an empty list if no features are selected).");

            RuleFor(x => x.SelectedFeatureIds)
                .MustAsync(AllFeaturesValidForCarsAsync)
                .WithMessage("One or more selected features are not available for this vehicle type.");
        }

        private async Task<bool> VehicleModelBelongsToBrandAsync(
            CreateCarListingCommand command,
            CancellationToken cancellationToken)
        {
            return await _context.VehicleModels.AnyAsync(
                m => m.Id == command.VehicleModelId && m.BrandId == command.BrandId,
                cancellationToken);
        }

        private async Task<bool> AllFeaturesValidForCarsAsync(
            List<int>? featureIds,
            CancellationToken cancellationToken)
        {
            if (featureIds is null || featureIds.Count == 0)
            {
                return true;
            }

            var distinctIds = featureIds.Distinct().ToList();

            var carsVehicleTypeId = await _context.VehicleTypes
                .Where(vt => vt.Slug == CarsVehicleTypeSlug)
                .Select(vt => vt.Id)
                .SingleOrDefaultAsync(cancellationToken);

            if (carsVehicleTypeId == 0)
            {
                // Реална server misconfiguration (липсващ/преименуван seed ред
                // за VehicleType), не invalid user input — не искаме да го
                // маскираме като обикновена validation грешка.
                throw new InvalidOperationException(
                    $"VehicleType with slug '{CarsVehicleTypeSlug}' was not found. Check seed data/migrations.");
            }

            var validCount = await _context.VehicleTypeFeatures
                .Where(vtf => vtf.VehicleTypeId == carsVehicleTypeId
                    && distinctIds.Contains(vtf.FeatureId))
                .CountAsync(cancellationToken);

            return validCount == distinctIds.Count;
        }
    }
}