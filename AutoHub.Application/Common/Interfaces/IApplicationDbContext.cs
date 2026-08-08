using AutoHub.Domain.Entities;
using AutoHub.Domain.Entities.Features;
using AutoHub.Domain.Entities.Listings;
using AutoHub.Domain.Entities.Vehicles;
using Microsoft.EntityFrameworkCore;

namespace AutoHub.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Brand> Brands { get; }
        DbSet<VehicleModel> VehicleModels { get; }
        DbSet<VehicleType> VehicleTypes { get; }
        DbSet<Vehicle> Vehicles { get; }
        DbSet<Car> Cars { get; }
        DbSet<Listing> Listings { get; }
        DbSet<ListingImage> ListingImages { get; }
        DbSet<Favorite> Favorites { get; }
        DbSet<Feature> Features { get; }
        DbSet<FeatureCategory> FeatureCategories { get; }
        DbSet<VehicleSelectedFeature> VehicleSelectedFeatures { get; }
        DbSet<VehicleTypeFeature> VehicleTypeFeatures { get; }
        DbSet<EngineType> EngineTypes { get; }
        DbSet<Transmission> Transmissions { get; }
        DbSet<EuroStandard> EuroStandards { get; }
        DbSet<Color> Colors { get; }
        DbSet<BodyType> BodyTypes { get; }
        DbSet<Location> Locations { get; }

        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}