using AutoHub.Application.Common.Interfaces;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using static AutoHub.Domain.Constants.Listings.ListingQueryConstants;

namespace AutoHub.Application.Listings.Queries.GetListings
{
    public class GetListingsQueryValidator : AbstractValidator<GetListingsQuery>
    {
        private readonly IApplicationDbContext _context;

        public GetListingsQueryValidator(IApplicationDbContext context)
        {
            _context = context;

            RuleFor(x => x.Page).GreaterThanOrEqualTo(1);
            RuleFor(x => x.PageSize).InclusiveBetween(1, MaxPageSize);

            RuleFor(x => x)
                .Must(x => !x.MinPrice.HasValue || !x.MaxPrice.HasValue || x.MinPrice <= x.MaxPrice)
                .WithMessage("MinPrice must not be greater than MaxPrice.");

            RuleFor(x => x)
                .Must(x => !x.MinYear.HasValue || !x.MaxYear.HasValue || x.MinYear <= x.MaxYear)
                .WithMessage("MinYear must not be greater than MaxYear.");

            RuleFor(x => x.BrandId)
                .MustAsync(async (id, ct) => id == null || await _context.Brands.AnyAsync(b => b.Id == id, ct))
                .WithMessage("Selected brand does not exist.");

            RuleFor(x => x)
                .MustAsync(VehicleModelIsValidAsync)
                .WithMessage("Selected model does not belong to the selected brand.");

            RuleFor(x => x.LocationId)
                .MustAsync(async (id, ct) => id == null || await _context.Locations.AnyAsync(l => l.Id == id, ct))
                .WithMessage("Selected location does not exist.");

            RuleFor(x => x.BodyTypeId)
                .MustAsync(async (id, ct) => id == null || await _context.BodyTypes.AnyAsync(b => b.Id == id, ct))
                .WithMessage("Selected body type does not exist.");

            RuleFor(x => x.ColorId)
                .MustAsync(async (id, ct) => id == null || await _context.Colors.AnyAsync(c => c.Id == id, ct))
                .WithMessage("Selected color does not exist.");

            RuleFor(x => x.EngineTypeId)
                .MustAsync(async (id, ct) => id == null || await _context.EngineTypes.AnyAsync(e => e.Id == id, ct))
                .WithMessage("Selected engine type does not exist.");

            RuleFor(x => x.TransmissionId)
                .MustAsync(async (id, ct) => id == null || await _context.Transmissions.AnyAsync(t => t.Id == id, ct))
                .WithMessage("Selected transmission does not exist.");
        }

        private async Task<bool> VehicleModelIsValidAsync(GetListingsQuery query, CancellationToken cancellationToken)
        {
            if (query.VehicleModelId is null)
            {
                return true;
            }

            if (query.BrandId is null)
            {
                return await _context.VehicleModels.AnyAsync(m => m.Id == query.VehicleModelId, cancellationToken);
            }

            return await _context.VehicleModels.AnyAsync(
                m => m.Id == query.VehicleModelId && m.BrandId == query.BrandId, cancellationToken);
        }
    }
}