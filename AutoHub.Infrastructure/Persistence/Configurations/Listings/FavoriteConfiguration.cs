using AutoHub.Domain.Entities.Listings;
using AutoHub.Infrastructure.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutoHub.Infrastructure.Persistence.Configurations.Listings
{
    public class FavoriteConfiguration : IEntityTypeConfiguration<Favorite>
    {
        public void Configure(EntityTypeBuilder<Favorite> builder)
        {
            builder.ToTable("Favorites");

            builder.HasKey(f => new
            {
                f.UserId,
                f.ListingId
            });

            builder.HasOne(f => f.Listing)
                .WithMany(l => l.Favorites)
                .HasForeignKey(f => f.ListingId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne<ApplicationUser>()
                .WithMany(u => u.Favorites)
                .HasForeignKey(f => f.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // Премахнат redundant unique индекс — PK (UserId, ListingId)
            // вече гарантира уникалност и има свой unique clustered индекс.

            builder.HasQueryFilter(f => !f.Listing.IsDeleted);
        }
    }
}