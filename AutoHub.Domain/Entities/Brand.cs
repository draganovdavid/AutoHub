using AutoHub.Domain.Common;
using AutoHub.Domain.Entities.Vehicles;

namespace AutoHub.Domain.Entities
{
    public class Brand : BaseEntity<int>, ILookupEntity
    {
        public string Name { get; set; } = null!;

        public bool IsActive { get; set; } = true;

        public ICollection<VehicleModel> Models { get; set; } = new List<VehicleModel>();
    }
}