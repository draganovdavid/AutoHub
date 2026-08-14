using AutoHub.Application.Common.Models;
using MediatR;

namespace AutoHub.Application.Listings.Queries.GetListings
{
    public record GetListingsQuery(
        string? SearchTerm,
        int? BrandId,
        int? VehicleModelId,
        int? LocationId,
        int? BodyTypeId,
        int? ColorId,
        int? EngineTypeId,
        int? TransmissionId,
        decimal? MinPrice,
        decimal? MaxPrice,
        int? MinYear,
        int? MaxYear,
        int? MaxMileage,
        ListingSortOrder SortOrder,
        int Page,
        int PageSize
    ) : IRequest<PaginatedList<ListingSummaryDto>>;
}