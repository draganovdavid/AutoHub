using AutoHub.Api.Contracts.Listings;
using AutoHub.Application.Common.Exceptions;
using AutoHub.Application.Common.Interfaces;
using AutoHub.Application.Listings.Commands.CreateCarListing;
using AutoHub.Application.Listings.Queries.GetListingById;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AutoHub.Api.Controllers
{
    [ApiController]
    [Route("api/listings")]
    public class ListingsController : ControllerBase
    {
        private readonly ISender _sender;
        private readonly ICurrentUserService _currentUserService;

        public ListingsController(ISender sender, ICurrentUserService currentUserService)
        {
            _sender = sender;
            _currentUserService = currentUserService;
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<ListingDto>> GetById(Guid id, CancellationToken cancellationToken)
        {
            var result = await _sender.Send(new GetListingByIdQuery(id), cancellationToken);
            return Ok(result);
        }

        [Authorize]
        [HttpPost("cars")]
        public async Task<ActionResult<Guid>> CreateCarListing(
            [FromBody] CreateCarListingRequest request,
            CancellationToken cancellationToken)
        {
            var sellerId = _currentUserService.UserId
                ?? throw new AuthenticationException("Unable to resolve the current user.");

            var command = new CreateCarListingCommand(
                Title: request.Title,
                Description: request.Description,
                Price: request.Price,
                IsPriceOnRequest: request.IsPriceOnRequest,
                WithVat: request.WithVat,
                PhoneNumber: request.PhoneNumber,
                LocationId: request.LocationId,
                SellerId: sellerId,
                BrandId: request.BrandId,
                VehicleModelId: request.VehicleModelId,
                ProductionYear: request.ProductionYear,
                ProductionMonth: request.ProductionMonth,
                Mileage: request.Mileage,
                Horsepower: request.Horsepower,
                EngineCapacity: request.EngineCapacity,
                VinNumber: request.VinNumber,
                EngineTypeId: request.EngineTypeId,
                TransmissionId: request.TransmissionId,
                EuroStandardId: request.EuroStandardId,
                ColorId: request.ColorId,
                BodyTypeId: request.BodyTypeId,
                SelectedFeatureIds: request.SelectedFeatureIds
            );

            var id = await _sender.Send(command, cancellationToken);
            return CreatedAtAction(nameof(GetById), new { id }, id);
        }
    }
}