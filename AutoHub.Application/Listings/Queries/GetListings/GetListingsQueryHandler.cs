using AutoHub.Application.Common.Interfaces;
using AutoHub.Application.Common.Models;
using AutoHub.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using MediatR;

namespace AutoHub.Application.Listings.Queries.GetListings
{
    public class GetListingsQueryHandler : IRequestHandler<GetListingsQuery, PaginatedList<ListingSummaryDto>>
    {
        private readonly IApplicationDbContext _context;

        public GetListingsQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<PaginatedList<ListingSummaryDto>> Handle(
            GetListingsQuery request, CancellationToken cancellationToken)
        {
            var query =
                from listing in _context.Listings.AsNoTracking()
                where listing.Status == ListingStatus.Active
                join car in _context.Cars.AsNoTracking() on listing.VehicleId equals car.Id
                join brand in _context.Brands.AsNoTracking() on car.BrandId equals brand.Id
                join model in _context.VehicleModels.AsNoTracking() on car.VehicleModelId equals model.Id
                join location in _context.Locations.AsNoTracking() on listing.LocationId equals location.Id
                select new { listing, car, brand, model, location };

            if (!string.IsNullOrWhiteSpace(request.SearchTerm))
            {
                var term = request.SearchTerm.Trim();
                query = query.Where(x => x.listing.Title.Contains(term));
            }

            if (request.BrandId.HasValue)
            {
                query = query.Where(x => x.car.BrandId == request.BrandId);
            }

            if (request.VehicleModelId.HasValue)
            {
                query = query.Where(x => x.car.VehicleModelId == request.VehicleModelId);
            }

            if (request.LocationId.HasValue)
            {
                query = query.Where(x => x.listing.LocationId == request.LocationId);
            }

            if (request.BodyTypeId.HasValue)
            {
                query = query.Where(x => x.car.BodyTypeId == request.BodyTypeId);
            }

            if (request.ColorId.HasValue)
            {
                query = query.Where(x => x.car.ColorId == request.ColorId);
            }

            if (request.EngineTypeId.HasValue)
            {
                query = query.Where(x => x.car.EngineTypeId == request.EngineTypeId);
            }

            if (request.TransmissionId.HasValue)
            {
                query = query.Where(x => x.car.TransmissionId == request.TransmissionId);
            }

            if (request.MinPrice.HasValue)
            {
                query = query.Where(x => x.listing.Price >= request.MinPrice);
            }

            if (request.MaxPrice.HasValue)
            {
                query = query.Where(x => x.listing.Price <= request.MaxPrice);
            }

            if (request.MinYear.HasValue)
            {
                query = query.Where(x => x.car.ProductionYear >= request.MinYear);
            }

            if (request.MaxYear.HasValue)
            {
                query = query.Where(x => x.car.ProductionYear <= request.MaxYear);
            }

            if (request.MaxMileage.HasValue)
            {
                query = query.Where(x => x.car.Mileage <= request.MaxMileage);
            }

            query = request.SortOrder switch
            {
                ListingSortOrder.PriceAsc => query.OrderBy(x => x.listing.Price),
                ListingSortOrder.PriceDesc => query.OrderByDescending(x => x.listing.Price),
                ListingSortOrder.MileageAsc => query.OrderBy(x => x.car.Mileage),
                ListingSortOrder.YearDesc => query.OrderByDescending(x => x.car.ProductionYear),
                _ => query.OrderByDescending(x => x.listing.CreatedAt)
            };

            var totalCount = await query.CountAsync(cancellationToken);

            var items = await query
                .Skip((request.Page - 1) * request.PageSize)
                .Take(request.PageSize)
                .Select(x => new ListingSummaryDto
                {
                    Id = x.listing.Id,
                    Title = x.listing.Title,
                    Price = x.listing.Price,
                    IsPriceOnRequest = x.listing.IsPriceOnRequest,
                    WithVat = x.listing.WithVat,
                    BrandName = x.brand.Name,
                    ModelName = x.model.Name,
                    ProductionYear = x.car.ProductionYear,
                    Mileage = x.car.Mileage,
                    LocationName = x.location.Name,
                    CreatedAt = x.listing.CreatedAt
                })
                .ToListAsync(cancellationToken);

            return new PaginatedList<ListingSummaryDto>
            {
                Items = items,
                Page = request.Page,
                PageSize = request.PageSize,
                TotalCount = totalCount,
                TotalPages = (int)Math.Ceiling(totalCount / (double)request.PageSize)
            };
        }
    }
}