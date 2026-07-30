using AutoHub.Domain.Entities.Features;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

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
                .HasMaxLength(150);

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
        }
    }
}