using AutoHub.Domain.Common;

namespace AutoHub.Domain.Entities
{
    public class VehicleModel : BaseEntity<int>
    {
        public string Name { get; set; } = null!;

        public int BrandId { get; set; }
        public Brand Brand { get; set; } = null!;
    }
}