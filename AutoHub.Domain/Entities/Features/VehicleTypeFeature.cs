using AutoHub.Domain.Entities.Vehicles;

namespace AutoHub.Domain.Entities.Features
{
    public class VehicleTypeFeature
    {
        public int VehicleTypeId { get; set; }

        public VehicleType VehicleType { get; set; } = null!;


        public int FeatureId { get; set; }

        public Feature Feature { get; set; } = null!;
    }
}