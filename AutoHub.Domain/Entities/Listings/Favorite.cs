using AutoHub.Domain.Common;

namespace AutoHub.Domain.Entities.Listings
{
    public class Favorite : BaseEntity<Guid>
    {
        public Guid UserId { get; set; }

        public Guid ListingId { get; set; }

        public Listing Listing { get; set; } = null!;
    }
}