using AutoHub.Domain.Entities;

namespace AutoHub.Infrastructure.Persistence.Seed
{
    internal static class ColorSeedData
    {
        internal static readonly Color[] Data =
        {
            new() { Id = 1, Name = "Бяло", IsActive = true },
            new() { Id = 2, Name = "Черно", IsActive = true },
            new() { Id = 3, Name = "Сиво", IsActive = true },
            new() { Id = 4, Name = "Сребристо", IsActive = true },
            new() { Id = 5, Name = "Синьо", IsActive = true },
            new() { Id = 6, Name = "Червено", IsActive = true },
            new() { Id = 7, Name = "Зелено", IsActive = true },
            new() { Id = 8, Name = "Кафяво", IsActive = true },
            new() { Id = 9, Name = "Жълто", IsActive = true },
            new() { Id = 10, Name = "Оранжево", IsActive = true }
        };
    }
}