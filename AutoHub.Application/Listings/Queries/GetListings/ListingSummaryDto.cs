namespace AutoHub.Application.Listings.Queries.GetListings
{
    public class ListingSummaryDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = null!;
        public decimal? Price { get; set; }
        public bool IsPriceOnRequest { get; set; }
        public bool WithVat { get; set; }
        public string BrandName { get; set; } = null!;
        public string ModelName { get; set; } = null!;
        public int ProductionYear { get; set; }
        public int Mileage { get; set; }
        public string LocationName { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
    }
}