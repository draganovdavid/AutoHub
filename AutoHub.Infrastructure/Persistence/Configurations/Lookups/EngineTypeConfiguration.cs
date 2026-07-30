using AutoHub.Domain.Entities;
using AutoHub.Infrastructure.Persistence.Seed;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static AutoHub.Domain.Constants.Lookups.EngineTypeConstants;

namespace AutoHub.Infrastructure.Persistence.Configurations.Lookups
{
    public class EngineTypeConfiguration : IEntityTypeConfiguration<EngineType>
    {
        public void Configure(EntityTypeBuilder<EngineType> builder)
        {
            builder.ToTable("EngineTypes");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(EngineTypeNameMaxLength);

            builder.Property(x => x.IsActive)
                .HasDefaultValue(true);

            builder.HasIndex(x => x.Name)
                .IsUnique();

            builder.HasData(EngineTypeSeedData.Data);
        }
    }
}