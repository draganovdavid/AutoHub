namespace AutoHub.Domain.Entities.Listings
{
    public class Favorite
    {
        public Guid UserId { get; set; }
        // Виж коментара в Listing.cs — същата причина: ApplicationUser е
        // Infrastructure тип, Domain не трябва да го реферира директно.

        public Guid ListingId { get; set; }
        public Listing Listing { get; set; } = null!;
    }
}