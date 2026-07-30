using AutoHub.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

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
                .HasMaxLength(10);

            builder.Property(x => x.IsActive)
                .HasDefaultValue(true);

            builder.HasIndex(x => x.Name)
                .IsUnique();
        }
    }
}