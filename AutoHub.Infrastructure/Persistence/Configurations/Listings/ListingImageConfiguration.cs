using AutoHub.Domain.Entities.Listings;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static AutoHub.Domain.Constants.Listings.ListingImageConstants;


namespace AutoHub.Infrastructure.Persistence.Configurations.Listings
{
    public class ListingImageConfiguration : IEntityTypeConfiguration<ListingImage>
    {
        public void Configure(EntityTypeBuilder<ListingImage> builder)
        {
            builder.ToTable("ListingImages");

            builder.HasKey(i => i.Id);

            builder.Property(i => i.FileName)
                .IsRequired()
                .HasMaxLength(FileNameMaxLength);

            builder.Property(i => i.FilePath)
                .IsRequired()
                .HasMaxLength(FilePathMaxLength);

            builder.Property(i => i.ContentType)
                .IsRequired()
                .HasMaxLength(ContentTypeMaxLength);

            builder.Property(i => i.FileSize)
                .IsRequired();

            builder.Property(i => i.DisplayOrder)
                .HasDefaultValue(0);

            builder.Property(i => i.IsPrimary)
                .HasDefaultValue(false);

            builder.Property(i => i.Extension)
                .IsRequired()
                .HasMaxLength(ExtensionMaxLength);

            builder.HasOne(i => i.Listing)
                .WithMany(l => l.Images)
                .HasForeignKey(i => i.ListingId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasIndex(i => new
            {
                i.ListingId,
                i.DisplayOrder
            });

            builder.HasIndex(i => i.ListingId)
                .HasFilter("[IsPrimary] = 1")
                .IsUnique();

            builder.HasQueryFilter(li => !li.Listing.IsDeleted);
        }
    }
}