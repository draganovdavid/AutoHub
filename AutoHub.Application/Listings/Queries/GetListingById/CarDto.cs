namespace AutoHub.Application.Listings.Queries.GetListingById
{
    public class CarDto
    {
        public string BrandName { get; set; } = null!;
        public string ModelName { get; set; } = null!;
        public int ProductionYear { get; set; }
        public string ProductionMonth { get; set; } = null!;
        public int Mileage { get; set; }
        public int Horsepower { get; set; }
        public int? EngineCapacity { get; set; }
        public string? VinNumber { get; set; }
        public string EngineTypeName { get; set; } = null!;
        public string TransmissionName { get; set; } = null!;
        public string EuroStandardName { get; set; } = null!;
        public string ColorName { get; set; } = null!;
        public string BodyTypeName { get; set; } = null!;
        public List<string> Features { get; set; } = new();
    }
}