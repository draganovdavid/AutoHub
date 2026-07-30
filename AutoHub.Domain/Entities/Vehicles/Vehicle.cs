using AutoHub.Domain.Common;
using AutoHub.Domain.Entities.Features;
using AutoHub.Domain.Enums;

namespace AutoHub.Domain.Entities.Vehicles
{
    public abstract class Vehicle : BaseEntity<int>
    {
        public int BrandId { get; set; }
        public Brand Brand { get; set; } = null!;

        public int VehicleModelId { get; set; }
        public VehicleModel VehicleModel { get; set; } = null!;

        public int VehicleTypeId { get; set; }
        public VehicleType VehicleType { get; set; } = null!;

        public int ProductionYear { get; set; }

        public Month ProductionMonth { get; set; }

        public ICollection<VehicleSelectedFeature> SelectedFeatures { get; set; }
            = new List<VehicleSelectedFeature>();
    }
}