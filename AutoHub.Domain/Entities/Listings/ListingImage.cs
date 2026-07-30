using AutoHub.Domain.Common;

namespace AutoHub.Domain.Entities.Listings
{
    public class ListingImage : BaseEntity<Guid>
    {
        public Guid ListingId { get; set; }
        public Listing Listing { get; set; } = null!;

        public string FileName { get; set; } = null!;

        public string FilePath { get; set; } = null!;

        public string ContentType { get; set; } = null!;

        public long FileSize { get; set; }

        public bool IsPrimary { get; set; }

        public int DisplayOrder { get; set; }

        public string Extension { get; set; } = null!;

        public DateTime UploadedAt { get; set; }
    }
}