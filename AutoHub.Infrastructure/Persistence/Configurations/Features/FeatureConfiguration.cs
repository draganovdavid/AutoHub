using AutoHub.Domain.Entities.Features;
using AutoHub.Infrastructure.Persistence.Seed;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static AutoHub.Domain.Constants.Features.FeatureConstants;

namespace AutoHub.Infrastructure.Persistence.Configurations.Features
{
    public class FeatureConfiguration : IEntityTypeConfiguration<Feature>
    {
        public void Configure(EntityTypeBuilder<Feature> builder)
        {
            builder.ToTable("Features");

            builder.HasKey(f => f.Id);

            builder.Property(f => f.Name)
                .IsRequired()
                .HasMaxLength(NameMaxLength);

            builder.Property(f => f.IsActive)
                .HasDefaultValue(true);

            builder.HasIndex(f => new
            {
                f.FeatureCategoryId,
                f.Name
            })
            .IsUnique();

            builder.HasOne(f => f.FeatureCategory)
                .WithMany(fc => fc.Features)
                .HasForeignKey(f => f.FeatureCategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(FeatureSeedData.Data);
        }
    }
}