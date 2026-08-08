using MediatR;

namespace AutoHub.Application.Listings.Queries.GetListingById
{
    public record GetListingByIdQuery(Guid Id) : IRequest<ListingDto>;
}