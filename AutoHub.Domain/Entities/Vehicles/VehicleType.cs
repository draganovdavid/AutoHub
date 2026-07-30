using AutoHub.Domain.Common;
using AutoHub.Domain.Entities.Features;

namespace AutoHub.Domain.Entities.Vehicles
{
    public class VehicleType : BaseEntity<int>
    {
        public string Name { get; set; } = null!;

        public string Slug { get; set; } = null!;

        public bool IsActive { get; set; } = true;

        public ICollection<VehicleTypeFeature> VehicleTypeFeatures { get; set; }
            = new List<VehicleTypeFeature>();
    }
}