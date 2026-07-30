using AutoHub.Domain.Entities;

namespace AutoHub.Infrastructure.Persistence.Seed
{
    internal static class EngineTypeSeedData
    {
        internal static readonly EngineType[] Data =
        {
            new() { Id = 1, Name = "Бензинов", IsActive = true },
            new() { Id = 2, Name = "Дизелов", IsActive = true },
            new() { Id = 3, Name = "Електрически", IsActive = true },
            new() { Id = 4, Name = "Хибриден", IsActive = true },
            new() { Id = 5, Name = "Plug-in хибрид", IsActive = true },
            new() { Id = 6, Name = "Газ", IsActive = true },
            new() { Id = 7, Name = "Водород", IsActive = true }
        };
    }
}