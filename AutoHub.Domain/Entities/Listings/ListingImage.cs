using AutoHub.Domain.Common;

namespace AutoHub.Domain.Entities.Listings
{
    public class ListingImage : BaseEntity<Guid>
    {
        public Guid ListingId { get; set; }

        public Listing Listing { get; set; } = null!;

        public string ImageUrl { get; set; } = null!;

        public bool IsMain { get; set; }

        public int DisplayOrder { get; set; }
    }
}