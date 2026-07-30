using AutoHub.Domain.Entities;

namespace AutoHub.Infrastructure.Persistence.Seed
{
    internal static class EuroStandardSeedData
    {
        internal static readonly EuroStandard[] Data =
        {
            new() { Id = 1, Name = "Euro 1", IsActive = true },
            new() { Id = 2, Name = "Euro 2", IsActive = true },
            new() { Id = 3, Name = "Euro 3", IsActive = true },
            new() { Id = 4, Name = "Euro 4", IsActive = true },
            new() { Id = 5, Name = "Euro 5", IsActive = true },
            new() { Id = 6, Name = "Euro 6", IsActive = true }
        };
    }
}