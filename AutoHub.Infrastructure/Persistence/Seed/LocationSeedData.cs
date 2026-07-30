using AutoHub.Domain.Entities;

namespace AutoHub.Infrastructure.Persistence.Seed
{
    internal static class LocationSeedData
    {
        internal static readonly Location[] Data =
        {
            new() { Id = 1, Name = "София", IsActive = true },
            new() { Id = 2, Name = "Пловдив", IsActive = true },
            new() { Id = 3, Name = "Варна", IsActive = true },
            new() { Id = 4, Name = "Бургас", IsActive = true },
            new() { Id = 5, Name = "Русе", IsActive = true },
            new() { Id = 6, Name = "Стара Загора", IsActive = true },
            new() { Id = 7, Name = "Плевен", IsActive = true },
            new() { Id = 8, Name = "Сливен", IsActive = true },
            new() { Id = 9, Name = "Добрич", IsActive = true },
            new() { Id = 10, Name = "Шумен", IsActive = true },
            new() { Id = 11, Name = "Перник", IsActive = true },
            new() { Id = 12, Name = "Хасково", IsActive = true },
            new() { Id = 13, Name = "Пазарджик", IsActive = true },
            new() { Id = 14, Name = "Благоевград", IsActive = true },
            new() { Id = 15, Name = "Велико Търново", IsActive = true },
        };
    }
}