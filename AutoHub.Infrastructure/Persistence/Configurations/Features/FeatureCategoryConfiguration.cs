using AutoHub.Domain.Entities.Features;
using AutoHub.Infrastructure.Persistence.Seed;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static AutoHub.Domain.Constants.Features.FeatureCategoryConstants;

namespace AutoHub.Infrastructure.Persistence.Configurations.Features
{
    public class FeatureCategoryConfiguration : IEntityTypeConfiguration<FeatureCategory>
    {
        public void Configure(EntityTypeBuilder<FeatureCategory> builder)
        {
            builder.ToTable("FeatureCategories");

            builder.HasKey(fc => fc.Id);

            builder.Property(fc => fc.Name)
                .IsRequired()
                .HasMaxLength(NameMaxLength);

            builder.Property(fc => fc.IsActive)
                .HasDefaultValue(true);

            builder.HasIndex(fc => fc.Name)
                .IsUnique();

            builder.HasMany(fc => fc.Features)
                .WithOne(f => f.FeatureCategory)
                .HasForeignKey(f => f.FeatureCategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(FeatureCategorySeedData.Data);
        }
    }
}
