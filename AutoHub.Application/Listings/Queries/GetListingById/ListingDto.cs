namespace AutoHub.Application.Listings.Queries.GetListingById
{
    public class ListingDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public bool IsPriceOnRequest { get; set; }
        public bool WithVat { get; set; }
        public string Status { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public int ViewCount { get; set; }
        public DateTime CreatedAt { get; set; }

        // Само суровият ID засега.
        public Guid SellerId { get; set; }

        public string LocationName { get; set; } = null!;

        public CarDto Vehicle { get; set; } = null!;
    }
}