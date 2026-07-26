using AutoHub.Domain.Entities.Listings;
using Microsoft.AspNetCore.Identity;

namespace AutoHub.Domain.Identity
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public string DisplayName { get; set; } = null!;

        public DateTime CreatedAt { get; init; } = DateTime.UtcNow;

        public ICollection<Listing> Listings { get; set; }
            = new List<Listing>();

        public ICollection<Favorite> Favorites { get; set; }
            = new List<Favorite>();
    }
}