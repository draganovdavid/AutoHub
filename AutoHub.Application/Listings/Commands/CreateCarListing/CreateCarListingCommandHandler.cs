using AutoHub.Application.Common.Interfaces;
using AutoHub.Domain.Entities.Features;
using AutoHub.Domain.Entities.Listings;
using AutoHub.Domain.Entities.Vehicles;
using AutoHub.Domain.Enums;
using MediatR;
using Microsoft.EntityFrameworkCore;

using static AutoHub.Domain.Constants.Vehicles.VehicleTypeConstants;

namespace AutoHub.Application.Listings.Commands.CreateCarListing
{
    public class CreateCarListingCommandHandler : IRequestHandler<CreateCarListingCommand, Guid>
    {
        private readonly IApplicationDbContext _context;

        public CreateCarListingCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Guid> Handle(CreateCarListingCommand request, CancellationToken cancellationToken)
        {
            // По времето, в който Handler-ът се изпълни, ValidationBehaviour вече
            // е потвърдил, че заявката е валидна — ако този VehicleType липсва,
            // това е реален server misconfiguration проблем, не invalid input,
            // затова SingleAsync (не SingleOrDefaultAsync) е нарочен избор тук.
            var carsVehicleTypeId = await _context.VehicleTypes
                .Where(vt => vt.Slug == CarsVehicleTypeSlug)
                .Select(vt => vt.Id)
                .SingleAsync(cancellationToken);

            var car = new Car
            {
                BrandId = request.BrandId,
                VehicleModelId = request.VehicleModelId,
                VehicleTypeId = carsVehicleTypeId,
                ProductionYear = request.ProductionYear,
                ProductionMonth = request.ProductionMonth,
                Mileage = request.Mileage,
                Horsepower = request.Horsepower,
                EngineCapacity = request.EngineCapacity,
                VinNumber = request.VinNumber,
                EngineTypeId = request.EngineTypeId,
                TransmissionId = request.TransmissionId,
                EuroStandardId = request.EuroStandardId,
                ColorId = request.ColorId,
                BodyTypeId = request.BodyTypeId
            };

            foreach (var featureId in request.SelectedFeatureIds.Distinct())
            {
                car.SelectedFeatures.Add(new VehicleSelectedFeature { FeatureId = featureId });
            }

            var listing = new Listing
            {
                Title = request.Title,
                Description = request.Description,
                Price = request.IsPriceOnRequest ? null : request.Price,
                IsPriceOnRequest = request.IsPriceOnRequest,
                WithVat = request.WithVat,
                Status = ListingStatus.Active,
                PhoneNumber = request.PhoneNumber,
                SellerId = request.SellerId,
                LocationId = request.LocationId,
                Vehicle = car
            };

            _context.Listings.Add(listing);

            await _context.SaveChangesAsync(cancellationToken);

            return listing.Id;
        }
    }
}