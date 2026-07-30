using AutoHub.Domain.Entities.Features;

namespace AutoHub.Infrastructure.Persistence.Seed
{
    internal static class FeatureCategorySeedData
    {
        internal static readonly FeatureCategory[] Data =
        {
            new() { Id = 1, Name = "Безопасност", IsActive = true },
            new() { Id = 2, Name = "Комфорт", IsActive = true },
            new() { Id = 3, Name = "Други", IsActive = true },
            new() { Id = 4, Name = "Защита", IsActive = true },
            new() { Id = 5, Name = "Интериор", IsActive = true },
            new() { Id = 6, Name = "Специализирани", IsActive = true },
            new() { Id = 7, Name = "Екстериор", IsActive = true }
        };
    }
}