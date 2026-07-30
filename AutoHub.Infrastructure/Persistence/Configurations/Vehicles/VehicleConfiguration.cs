using AutoHub.Domain.Entities.Vehicles;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutoHub.Infrastructure.Persistence.Configurations.Vehicles
{
    public class VehicleConfiguration : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            builder.ToTable("Vehicles");

            builder.HasKey(v => v.Id);

            builder.UseTptMappingStrategy();

            builder.Property(v => v.ProductionYear)
                .IsRequired();

            builder.Property(v => v.ProductionMonth)
                .IsRequired();

            builder.HasOne(v => v.Brand)
                .WithMany()
                .HasForeignKey(v => v.BrandId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(v => v.VehicleModel)
                .WithMany(vm => vm.Vehicles)
                .HasForeignKey(v => v.VehicleModelId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(v => v.VehicleType)
                .WithMany()
                .HasForeignKey(v => v.VehicleTypeId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(v => v.SelectedFeatures)
                .WithOne(sf => sf.Vehicle)
                .HasForeignKey(sf => sf.VehicleId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasIndex(v => new
            {
                v.BrandId,
                v.VehicleModelId,
                v.ProductionYear
            });
        }
    }
}