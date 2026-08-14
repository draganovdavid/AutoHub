using AutoHub.Application.Listings.Queries.GetListings;
using static AutoHub.Domain.Constants.Listings.ListingQueryConstants;

namespace AutoHub.Api.Contracts.Listings
{
    public class GetListingsRequest
    {
        public string? SearchTerm { get; set; }
        public int? BrandId { get; set; }
        public int? VehicleModelId { get; set; }
        public int? LocationId { get; set; }
        public int? BodyTypeId { get; set; }
        public int? ColorId { get; set; }
        public int? EngineTypeId { get; set; }
        public int? TransmissionId { get; set; }
        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }
        public int? MinYear { get; set; }
        public int? MaxYear { get; set; }
        public int? MaxMileage { get; set; }
        public ListingSortOrder SortOrder { get; set; } = ListingSortOrder.Newest;
        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = DefaultPageSize;
    }
}