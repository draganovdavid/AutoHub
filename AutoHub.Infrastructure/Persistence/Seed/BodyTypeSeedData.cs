using AutoHub.Domain.Entities;

namespace AutoHub.Infrastructure.Persistence.Seed
{
    internal static class BodyTypeSeedData
    {
        internal static readonly BodyType[] Data =
        {
            new() { Id = 1, Name = "Ван", IsActive = true },
            new() { Id = 2, Name = "Джип", IsActive = true },
            new() { Id = 3, Name = "Кабрио", IsActive = true },
            new() { Id = 4, Name = "Комби", IsActive = true },
            new() { Id = 5, Name = "Купе", IsActive = true },
            new() { Id = 6, Name = "Миниван", IsActive = true },
            new() { Id = 7, Name = "Седан", IsActive = true },
            new() { Id = 8, Name = "Стреч лимузина", IsActive = true },
            new() { Id = 9, Name = "Хечбек", IsActive = true }
        };
    }
}