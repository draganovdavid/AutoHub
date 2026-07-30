using AutoHub.Domain.Entities.Features;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutoHub.Infrastructure.Persistence.Configurations.Features
{
    public class VehicleTypeFeatureConfiguration : IEntityTypeConfiguration<VehicleTypeFeature>
    {
        public void Configure(EntityTypeBuilder<VehicleTypeFeature> builder)
        {
            builder.ToTable("VehicleTypeFeatures");

            builder.HasKey(vtf => new
            {
                vtf.VehicleTypeId,
                vtf.FeatureId
            });

            builder.HasOne(vtf => vtf.VehicleType)
                .WithMany(vt => vt.VehicleTypeFeatures)
                .HasForeignKey(vtf => vtf.VehicleTypeId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(vtf => vtf.Feature)
                .WithMany(f => f.VehicleTypeFeatures)
                .HasForeignKey(vtf => vtf.FeatureId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}