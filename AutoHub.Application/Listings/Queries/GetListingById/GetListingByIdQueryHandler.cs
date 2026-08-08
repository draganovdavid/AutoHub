using AutoHub.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace AutoHub.Application.Listings.Queries.GetListingById
{
    public class GetListingByIdQueryHandler : IRequestHandler<GetListingByIdQuery, ListingDto>
    {
        private readonly IApplicationDbContext _context;

        public GetListingByIdQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ListingDto> Handle(GetListingByIdQuery request, CancellationToken cancellationToken)
        {
            var result = await (
                from listing in _context.Listings.AsNoTracking()
                where listing.Id == request.Id
                join car in _context.Cars.AsNoTracking() on listing.VehicleId equals car.Id
                join brand in _context.Brands.AsNoTracking() on car.BrandId equals brand.Id
                join model in _context.VehicleModels.AsNoTracking() on car.VehicleModelId equals model.Id
                join engineType in _context.EngineTypes.AsNoTracking() on car.EngineTypeId equals engineType.Id
                join transmission in _context.Transmissions.AsNoTracking() on car.TransmissionId equals transmission.Id
                join euroStandard in _context.EuroStandards.AsNoTracking() on car.EuroStandardId equals euroStandard.Id
                join color in _context.Colors.AsNoTracking() on car.ColorId equals color.Id
                join bodyType in _context.BodyTypes.AsNoTracking() on car.BodyTypeId equals bodyType.Id
                join location in _context.Locations.AsNoTracking() on listing.LocationId equals location.Id
                select new
                {
                    Listing = listing,
                    Car = car,
                    BrandName = brand.Name,
                    ModelName = model.Name,
                    EngineTypeName = engineType.Name,
                    TransmissionName = transmission.Name,
                    EuroStandardName = euroStandard.Name,
                    ColorName = color.Name,
                    BodyTypeName = bodyType.Name,
                    LocationName = location.Name,
                    // Сгънато в главната заявка вместо отделен await по-долу —
                    // EF Core транслира това като correlated subquery в един SQL batch,
                    // не отделен round trip.
                    Features = _context.VehicleSelectedFeatures
                        .Where(sf => sf.VehicleId == car.Id)
                        .Select(sf => sf.Feature.Name)
                        .ToList()
                }
            ).SingleOrDefaultAsync(cancellationToken);

            if (result is null)
            {
                throw new KeyNotFoundException($"Listing with id {request.Id} was not found.");
            }

            return new ListingDto
            {
                Id = result.Listing.Id,
                Title = result.Listing.Title,
                Description = result.Listing.Description,
                Price = result.Listing.Price,
                IsPriceOnRequest = result.Listing.IsPriceOnRequest,
                WithVat = result.Listing.WithVat,
                Status = result.Listing.Status.ToString(),
                PhoneNumber = result.Listing.PhoneNumber,
                ViewCount = result.Listing.ViewCount,
                CreatedAt = result.Listing.CreatedAt,
                SellerId = result.Listing.SellerId,
                LocationName = result.LocationName,
                Vehicle = new CarDto
                {
                    BrandName = result.BrandName,
                    ModelName = result.ModelName,
                    ProductionYear = result.Car.ProductionYear,
                    ProductionMonth = result.Car.ProductionMonth.ToString(),
                    Mileage = result.Car.Mileage,
                    Horsepower = result.Car.Horsepower,
                    EngineCapacity = result.Car.EngineCapacity,
                    VinNumber = result.Car.VinNumber,
                    EngineTypeName = result.EngineTypeName,
                    TransmissionName = result.TransmissionName,
                    EuroStandardName = result.EuroStandardName,
                    ColorName = result.ColorName,
                    BodyTypeName = result.BodyTypeName,
                    Features = result.Features
                }
            };
        }
    }
}