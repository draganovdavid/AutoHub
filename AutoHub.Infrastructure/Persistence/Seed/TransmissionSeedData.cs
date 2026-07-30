using AutoHub.Domain.Entities;

namespace AutoHub.Infrastructure.Persistence.Seed
{
    internal static class TransmissionSeedData
    {
        internal static readonly Transmission[] Data =
        {
            new() { Id = 1, Name = "Ръчна", IsActive = true },
            new() { Id = 2, Name = "Автоматична", IsActive = true },
            new() { Id = 3, Name = "Полуавтоматична", IsActive = true }
        };
    }
}