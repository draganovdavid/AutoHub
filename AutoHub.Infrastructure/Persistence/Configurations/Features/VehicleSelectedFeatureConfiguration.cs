using AutoHub.Domain.Entities.Features;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutoHub.Infrastructure.Persistence.Configurations.Features
{
    public class VehicleSelectedFeatureConfiguration : IEntityTypeConfiguration<VehicleSelectedFeature>
    {
        public void Configure(EntityTypeBuilder<VehicleSelectedFeature> builder)
        {
            builder.ToTable("VehicleSelectedFeatures");

            builder.HasKey(vsf => new
            {
                vsf.VehicleId,
                vsf.FeatureId
            });

            builder.HasOne(vsf => vsf.Vehicle)
                .WithMany(v => v.SelectedFeatures)
                .HasForeignKey(vsf => vsf.VehicleId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(vsf => vsf.Feature)
                .WithMany(f => f.SelectedFeatures)
                .HasForeignKey(vsf => vsf.FeatureId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasIndex(vsf => vsf.FeatureId);
        }
    }
}