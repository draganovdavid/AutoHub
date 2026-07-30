using AutoHub.Domain.Entities;
using AutoHub.Infrastructure.Persistence.Seed;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static AutoHub.Domain.Constants.Vehicles.BrandConstants;

namespace AutoHub.Infrastructure.Persistence.Configurations.Vehicles
{
    public class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.ToTable("Brands");

            builder.HasKey(b => b.Id);

            builder.Property(b => b.Name)
                .HasMaxLength(BrandNameMaxLength)
                .IsRequired();

            builder.Property(b => b.IsActive)
                .HasDefaultValue(true);

            builder.HasIndex(b => b.Name)
                .IsUnique();

            builder.HasMany(b => b.Models)
                .WithOne(m => m.Brand)
                .HasForeignKey(m => m.BrandId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(BrandSeedData.Data);
        }
    }
}