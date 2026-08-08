using AutoHub.Domain.Entities.Listings;
using AutoHub.Infrastructure.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static AutoHub.Domain.Constants.Listings.ListingConstants;

namespace AutoHub.Infrastructure.Persistence.Configurations.Listings
{
    public class ListingConfiguration : IEntityTypeConfiguration<Listing>
    {
        public void Configure(EntityTypeBuilder<Listing> builder)
        {
            builder.ToTable("Listings");

            builder.HasKey(l => l.Id);

            builder.Property(l => l.Title)
                .IsRequired()
                .HasMaxLength(TitleMaxLength);

            builder.Property(l => l.Description)
                .HasMaxLength(DescriptionMaxLength);

            builder.Property(l => l.Price)
                .HasPrecision(18, 2);

            builder.Property(l => l.PhoneNumber)
                .IsRequired()
                .HasMaxLength(PhoneNumberMaxLength);

            builder.Property(l => l.Status)
                .HasConversion<int>();

            builder.Property(l => l.IsPriceOnRequest)
                .HasDefaultValue(false);

            builder.Property(l => l.WithVat)
                .HasDefaultValue(false);

            builder.Property(l => l.IsDeleted)
                .HasDefaultValue(false);

            builder.Property(l => l.CreatedAt)
                .HasDefaultValueSql("GETUTCDATE()");

            builder.HasOne(l => l.Vehicle)
                .WithOne()
                .HasForeignKey<Listing>(l => l.VehicleId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(l => l.Location)
                .WithMany()
                .HasForeignKey(l => l.LocationId)
                .OnDelete(DeleteBehavior.Restrict);

            // Seller релация: Listing няма navigation property (виж коментара
            // в Listing.cs), затова HasOne<T>() без lambda, а обратната
            // навигация идва от ApplicationUser.Listings.
            builder.HasOne<ApplicationUser>()
                .WithMany(u => u.Listings)
                .HasForeignKey(l => l.SellerId)
                .OnDelete(DeleteBehavior.Restrict);
            // Restrict, не Cascade: изтриването на потребител не трябва
            // автоматично да трие всичките му обяви (business decision -
            // ако искаш друго поведение, обмисли soft-delete на ApplicationUser
            // вместо hard delete + cascade).

            builder.HasMany(l => l.Images)
                .WithOne(i => i.Listing)
                .HasForeignKey(i => i.ListingId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(l => l.Favorites)
                .WithOne(f => f.Listing)
                .HasForeignKey(f => f.ListingId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasIndex(l => l.Status);
            builder.HasIndex(l => l.LocationId);
            builder.HasIndex(l => l.CreatedAt);
            builder.HasIndex(l => l.Price);
            builder.HasIndex(l => l.SellerId);

            builder.Property(x => x.RowVersion)
                .IsRowVersion();

            builder.HasQueryFilter(l => !l.IsDeleted);
        }
    }
}