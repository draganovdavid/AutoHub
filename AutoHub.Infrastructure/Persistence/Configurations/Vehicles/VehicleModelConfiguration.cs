using AutoHub.Domain.Entities.Vehicles;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutoHub.Infrastructure.Persistence.Configurations.Vehicles
{
    public class VehicleModelConfiguration : IEntityTypeConfiguration<VehicleModel>
    {
        public void Configure(EntityTypeBuilder<VehicleModel> builder)
        {
            builder.ToTable("VehicleModels");

            builder.HasKey(vm => vm.Id);

            builder.Property(vm => vm.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(vm => vm.IsActive)
                .HasDefaultValue(true);

            builder.HasOne(vm => vm.Brand)
                .WithMany(b => b.Models)
                .HasForeignKey(vm => vm.BrandId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(vm => vm.Vehicles)
                .WithOne(v => v.VehicleModel)
                .HasForeignKey(v => v.VehicleModelId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasIndex(vm => new
            {
                vm.BrandId,
                vm.Name
            })
            .IsUnique();
        }
    }
}