using AutoHub.Domain.Entities;

namespace AutoHub.Infrastructure.Persistence.Seed
{
    internal static class BrandSeedData
    {
        internal static readonly Brand[] Data =
        {
            new() { Id = 1, Name = "Mercedes-Benz", IsActive = true },
            new() { Id = 2, Name = "BMW", IsActive = true },
            new() { Id = 3, Name = "Audi", IsActive = true },
            new() { Id = 4, Name = "Volkswagen", IsActive = true },
            new() { Id = 5, Name = "Toyota", IsActive = true },
            new() { Id = 6, Name = "Ford", IsActive = true },
            new() { Id = 7, Name = "Opel", IsActive = true },
            new() { Id = 8, Name = "Renault", IsActive = true },
            new() { Id = 9, Name = "Peugeot", IsActive = true },
            new() { Id = 10, Name = "Škoda", IsActive = true }
        };
    }
}