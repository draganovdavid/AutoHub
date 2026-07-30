using AutoHub.Domain.Entities.Listings;
using AutoHub.Domain.Enums;
using Microsoft.AspNetCore.Identity;

namespace AutoHub.Domain.Identity
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public SellerType SellerType { get; set; } = SellerType.Individual;

        // Попълват се само когато SellerType == Dealer; за частни лица остават null.
        public string? CompanyName { get; set; }

        public string? CompanyLogoUrl { get; set; }

        public ICollection<Listing> Listings { get; set; } = new List<Listing>();

        public ICollection<Favorite> Favorites { get; set; } = new List<Favorite>();
    }
}