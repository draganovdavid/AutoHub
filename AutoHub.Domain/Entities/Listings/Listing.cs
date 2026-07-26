using AutoHub.Domain.Common;
using AutoHub.Domain.Entities.Vehicles;

namespace AutoHub.Domain.Entities.Listings
{
    public class Listing : AuditableEntity<Guid>
    {
        public string Title { get; set; } = null!;

        public decimal? Price { get; set; }

        public bool IsPriceOnRequest { get; set; }

        public bool WithVat { get; set; }

        public string PhoneNumber { get; set; } = null!;

        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; } = null!;

        public Guid SellerId { get; set; }

        public int LocationId { get; set; }
        public Location Location { get; set; } = null!;

        public ICollection<ListingImage> Images { get; set; }
            = new List<ListingImage>();
    }
}