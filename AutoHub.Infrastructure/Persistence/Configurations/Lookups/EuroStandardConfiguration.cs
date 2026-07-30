using AutoHub.Domain.Entities;
using AutoHub.Infrastructure.Persistence.Seed;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static AutoHub.Domain.Constants.Lookups.EuroStandardConstants;

namespace AutoHub.Infrastructure.Persistence.Configurations.Lookups
{
    public class EuroStandardConfiguration : IEntityTypeConfiguration<EuroStandard>
    {
        public void Configure(EntityTypeBuilder<EuroStandard> builder)
        {
            builder.ToTable("EuroStandards");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(EuroStandardNameMaxLength);

            builder.Property(x => x.IsActive)
                .HasDefaultValue(true);

            builder.HasIndex(x => x.Name)
                .IsUnique();

            builder.HasData(EuroStandardSeedData.Data);
        }
    }
}