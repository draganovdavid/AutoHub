using AutoHub.Domain.Common;
using AutoHub.Domain.Entities.Vehicles;
using AutoHub.Domain.Enums;

namespace AutoHub.Domain.Entities.Listings
{
    public class Listing : AuditableEntity<Guid>
    {
        public string Title { get; set; } = null!;

        public string? Description { get; set; }

        public decimal? Price { get; set; }

        public bool IsPriceOnRequest { get; set; }

        public bool WithVat { get; set; }

        public ListingStatus Status { get; set; }

        public string PhoneNumber { get; set; } = null!;

        public int ViewCount { get; set; }

        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; } = null!;

        public Guid SellerId { get; set; }
        // Няма navigation property към ApplicationUser тук нарочно:
        // ApplicationUser живее в Infrastructure слоя (наследява IdentityUser<Guid>),
        // а Domain не трябва да зависи от Infrastructure типове (Dependency Inversion).
        // Връзката се конфигурира изцяло във ListingConfiguration чрез Fluent API,
        // с ApplicationUser.Listings като обратна навигация.

        public int LocationId { get; set; }
        public Location Location { get; set; } = null!;

        public ICollection<ListingImage> Images { get; set; }
            = new List<ListingImage>();

        public ICollection<Favorite> Favorites { get; set; }
            = new List<Favorite>();
    }
}