using AutoHub.Domain.Entities.Vehicles;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using static AutoHub.Domain.Constants.Vehicles.CarConstants;

namespace AutoHub.Infrastructure.Persistence.Configurations.Vehicles
{
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.ToTable("Cars");

            builder.Property(c => c.Mileage)
                .IsRequired();

            builder.Property(c => c.Horsepower)
                .IsRequired();

            builder.Property(c => c.EngineCapacity);

            builder.Property(c => c.VinNumber)
                .HasMaxLength(VinNumberMaxLength);

            // VinNumber е НАРОЧНО не-уникален на DB ниво: потребителите (продавачи)
            // могат да сгрешат при ръчно въвеждане на VIN и не искаме unique
            // constraint violation да блокира публикуването на обява.
            // Ако в бъдеще се въведе VIN decoding/валидация на API ниво,
            // уникалността може да се enforce-не в application/domain слоя.
            builder.HasIndex(c => c.VinNumber)
                .IsUnique(false);

            builder.HasOne(c => c.EngineType)
                .WithMany()
                .HasForeignKey(c => c.EngineTypeId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.Transmission)
                .WithMany()
                .HasForeignKey(c => c.TransmissionId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.EuroStandard)
                .WithMany()
                .HasForeignKey(c => c.EuroStandardId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.Color)
                .WithMany()
                .HasForeignKey(c => c.ColorId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.BodyType)
                .WithMany()
                .HasForeignKey(c => c.BodyTypeId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}