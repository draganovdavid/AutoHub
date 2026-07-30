using AutoHub.Domain.Entities.Features;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

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
                .HasMaxLength(100);

            builder.Property(fc => fc.IsActive)
                .HasDefaultValue(true);

            builder.HasIndex(fc => fc.Name)
                .IsUnique();

            builder.HasMany(fc => fc.Features)
                .WithOne(f => f.FeatureCategory)
                .HasForeignKey(f => f.FeatureCategoryId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
