using AutoHub.Domain.Entities;
using AutoHub.Infrastructure.Persistence.Seed;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static AutoHub.Domain.Constants.Lookups.TransmissionConstants;

namespace AutoHub.Infrastructure.Persistence.Configurations.Lookups
{
    public class TransmissionConfiguration : IEntityTypeConfiguration<Transmission>
    {
        public void Configure(EntityTypeBuilder<Transmission> builder)
        {
            builder.ToTable("Transmissions");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(TransmissionNameMaxLength);

            builder.Property(x => x.IsActive)
                .HasDefaultValue(true);

            builder.HasIndex(x => x.Name)
                .IsUnique();

            builder.HasData(TransmissionSeedData.Data);
        }
    }
}