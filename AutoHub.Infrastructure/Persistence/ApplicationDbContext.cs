using AutoHub.Domain.Entities;
using AutoHub.Domain.Entities.Features;
using AutoHub.Domain.Entities.Listings;
using AutoHub.Domain.Entities.Vehicles;
using AutoHub.Domain.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AutoHub.Infrastructure.Persistence
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Listing> Listings { get; set; }
        public DbSet<ListingImage> ListingImages { get; set; }
        public DbSet<Favorite> Favorites { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<VehicleModel> VehicleModels { get; set; }
        public DbSet<VehicleType> VehicleTypes { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<FeatureCategory> FeatureCategories { get; set; }
        public DbSet<VehicleSelectedFeature> VehicleSelectedFeatures { get; set; }
        public DbSet<VehicleTypeFeature> VehicleTypeFeatures { get; set; }
        public DbSet<EngineType> EngineTypes { get; set; }
        public DbSet<Transmission> Transmissions { get; set; }
        public DbSet<EuroStandard> EuroStandards { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<BodyType> BodyTypes { get; set; }
        public DbSet<Location> Locations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
    }
}