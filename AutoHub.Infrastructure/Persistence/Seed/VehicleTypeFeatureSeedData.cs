using AutoHub.Domain.Entities.Features;

namespace AutoHub.Infrastructure.Persistence.Seed
{
    internal static class VehicleTypeFeatureSeedData
    {
        // Всички 96 features се асоциират с VehicleTypeId = 1 (Автомобили и джипове) —
        // единственият реално използван тип засега (Car : Vehicle).
        internal static readonly VehicleTypeFeature[] Data =
            Enumerable.Range(1, 96)
                .Select(featureId => new VehicleTypeFeature
                {
                    VehicleTypeId = 1,
                    FeatureId = featureId
                })
                .ToArray();
    }
}