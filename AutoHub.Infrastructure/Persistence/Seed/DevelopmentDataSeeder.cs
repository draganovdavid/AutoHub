using AutoHub.Domain.Constants.Identity;
using AutoHub.Domain.Enums;
using AutoHub.Infrastructure.Identity;
using Microsoft.EntityFrameworkCore;

namespace AutoHub.Infrastructure.Persistence.Seed
{
    public static class DevelopmentDataSeeder
    {
        public static async Task SeedAsync(ApplicationDbContext context, CancellationToken cancellationToken = default)
        {
            var exists = await context.Users
                .AnyAsync(u => u.Id == TestSellerConstants.TestSellerId, cancellationToken);

            if (exists)
            {
                return;
            }

            context.Users.Add(new ApplicationUser
            {
                Id = TestSellerConstants.TestSellerId,
                UserName = "test.seller@autohub.local",
                NormalizedUserName = "TEST.SELLER@AUTOHUB.LOCAL",
                Email = "test.seller@autohub.local",
                NormalizedEmail = "TEST.SELLER@AUTOHUB.LOCAL",
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                LockoutEnabled = true,
                SellerType = SellerType.Individual
            });

            await context.SaveChangesAsync(cancellationToken);
        }
    }
}