using AutoHub.Domain.Entities.Vehicles;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutoHub.Infrastructure.Persistence.Configurations.Vehicles
{
    public class VehicleTypeConfiguration : IEntityTypeConfiguration<VehicleType>
    {
        public void Configure(EntityTypeBuilder<VehicleType> builder)
        {
            builder.ToTable("VehicleTypes");

            builder.HasKey(vt => vt.Id);

            builder.Property(vt => vt.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(vt => vt.Slug)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(vt => vt.IsActive)
                .HasDefaultValue(true);

            builder.HasIndex(vt => vt.Name)
                .IsUnique();

            builder.HasIndex(vt => vt.Slug)
                .IsUnique();

            builder.HasMany(vt => vt.VehicleTypeFeatures)
                .WithOne(vtf => vtf.VehicleType)
                .HasForeignKey(vtf => vtf.VehicleTypeId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}