using AutoHub.Domain.Entities.Features;

namespace AutoHub.Domain.Entities.Vehicles
{
    public class Car : Vehicle
    {
        public int Horsepower { get; set; }

        public int? EngineCapacity { get; set; }

        public string? VinNumber { get; set; }

        public int EngineTypeId { get; set; }
        public EngineType EngineType { get; set; } = null!;

        public int TransmissionId { get; set; }
        public Transmission Transmission { get; set; } = null!;

        public int EuroStandardId { get; set; }
        public EuroStandard EuroStandard { get; set; } = null!;

        public int ColorId { get; set; }
        public Color Color { get; set; } = null!;

        public int BodyTypeId { get; set; }
        public BodyType BodyType { get; set; } = null!;

        public ICollection<VehicleSelectedFeature> Features { get; set; } = new List<VehicleSelectedFeature>();
    }
}