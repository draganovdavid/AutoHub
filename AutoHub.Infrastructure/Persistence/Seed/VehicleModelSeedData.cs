using AutoHub.Domain.Entities.Vehicles;

namespace AutoHub.Infrastructure.Persistence.Seed
{
    internal static class VehicleModelSeedData
    {
        internal static readonly VehicleModel[] Data =
        {
            // Mercedes-Benz (BrandId = 1)
            new() { Id = 1, BrandId = 1, Name = "A-Class", IsActive = true },
            new() { Id = 2, BrandId = 1, Name = "C-Class", IsActive = true },
            new() { Id = 3, BrandId = 1, Name = "E-Class", IsActive = true },
            new() { Id = 4, BrandId = 1, Name = "GLE", IsActive = true },

            // BMW (BrandId = 2)
            new() { Id = 5, BrandId = 2, Name = "3 Series", IsActive = true },
            new() { Id = 6, BrandId = 2, Name = "5 Series", IsActive = true },
            new() { Id = 7, BrandId = 2, Name = "X5", IsActive = true },

            // Audi (BrandId = 3)
            new() { Id = 8, BrandId = 3, Name = "A4", IsActive = true },
            new() { Id = 9, BrandId = 3, Name = "A6", IsActive = true },
            new() { Id = 10, BrandId = 3, Name = "Q5", IsActive = true },

            // Volkswagen (BrandId = 4)
            new() { Id = 11, BrandId = 4, Name = "Golf", IsActive = true },
            new() { Id = 12, BrandId = 4, Name = "Passat", IsActive = true },
            new() { Id = 13, BrandId = 4, Name = "Tiguan", IsActive = true },

            // Toyota (BrandId = 5)
            new() { Id = 14, BrandId = 5, Name = "Corolla", IsActive = true },
            new() { Id = 15, BrandId = 5, Name = "RAV4", IsActive = true },

            // Ford (BrandId = 6)
            new() { Id = 16, BrandId = 6, Name = "Focus", IsActive = true },
            new() { Id = 17, BrandId = 6, Name = "Fiesta", IsActive = true },

            // Opel (BrandId = 7)
            new() { Id = 18, BrandId = 7, Name = "Astra", IsActive = true },
            new() { Id = 19, BrandId = 7, Name = "Corsa", IsActive = true },

            // Renault (BrandId = 8)
            new() { Id = 20, BrandId = 8, Name = "Megane", IsActive = true },
            new() { Id = 21, BrandId = 8, Name = "Clio", IsActive = true },

            // Peugeot (BrandId = 9)
            new() { Id = 22, BrandId = 9, Name = "308", IsActive = true },
            new() { Id = 23, BrandId = 9, Name = "3008", IsActive = true },

            // Škoda (BrandId = 10)
            new() { Id = 24, BrandId = 10, Name = "Octavia", IsActive = true },
            new() { Id = 25, BrandId = 10, Name = "Superb", IsActive = true },
        };
    }
}