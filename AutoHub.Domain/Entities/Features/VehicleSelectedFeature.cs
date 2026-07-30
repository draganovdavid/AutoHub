using AutoHub.Domain.Entities.Vehicles;

namespace AutoHub.Domain.Entities.Features
{
    public class VehicleSelectedFeature
    {
        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; } = null!;


        public int FeatureId { get; set; }
        public Feature Feature { get; set; } = null!;
    }
}