using AutoHub.Domain.Common;
using AutoHub.Domain.Entities.Listings;
using AutoHub.Domain.Enums;

namespace AutoHub.Domain.Entities.Vehicles
{
    public abstract class Vehicle : BaseEntity<int>
    {
        public int BrandId { get; set; }
        public Brand Brand { get; set; } = null!;


        public int VehicleModelId { get; set; }
        public VehicleModel VehicleModel { get; set; } = null!;


        public int ProductionYear { get; set; }

        public Month ProductionMonth { get; set; }

        public int Mileage { get; set; }


        public Listing Listing { get; set; } = null!;
    }
}