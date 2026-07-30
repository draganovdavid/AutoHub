using AutoHub.Domain.Common;

namespace AutoHub.Domain.Entities.Vehicles
{
    public class VehicleModel : BaseEntity<int>
    {
        public string Name { get; set; } = null!;

        public int BrandId { get; set; }
        public Brand Brand { get; set; } = null!;

        public bool IsActive { get; set; } = true;

        public ICollection<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
    }
}