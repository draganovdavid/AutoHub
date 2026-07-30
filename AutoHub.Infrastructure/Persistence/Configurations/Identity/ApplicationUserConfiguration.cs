using AutoHub.Domain.Enums;
using AutoHub.Domain.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static AutoHub.Domain.Constants.Identity.ApplicationUserConstants;

namespace AutoHub.Infrastructure.Persistence.Configurations.Identity
{
    public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.Property(u => u.SellerType)
                .HasConversion<int>()
                .HasDefaultValue(SellerType.Individual)
                .HasSentinel(SellerType.Individual)
                .IsRequired();

            builder.Property(u => u.CompanyName)
                .HasMaxLength(CompanyNameMaxLength);

            builder.Property(u => u.CompanyLogoUrl)
                .HasMaxLength(CompanyLogoUrlMaxLength);
        }
    }
}