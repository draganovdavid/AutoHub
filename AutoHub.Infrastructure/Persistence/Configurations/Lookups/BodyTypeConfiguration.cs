using AutoHub.Domain.Entities;
using AutoHub.Infrastructure.Persistence.Seed;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static AutoHub.Domain.Constants.Lookups.BodyTypeConstants;

namespace AutoHub.Infrastructure.Persistence.Configurations.Lookups
{
    public class BodyTypeConfiguration : IEntityTypeConfiguration<BodyType>
    {
        public void Configure(EntityTypeBuilder<BodyType> builder)
        {
            builder.ToTable("BodyTypes");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(BodyTypeNameMaxLength);

            builder.Property(x => x.IsActive)
                .HasDefaultValue(true);

            builder.HasIndex(x => x.Name)
                .IsUnique();

            builder.HasData(BodyTypeSeedData.Data);
        }
    }
}