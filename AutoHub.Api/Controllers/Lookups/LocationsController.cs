using AutoHub.Application.Common.Interfaces;
using AutoHub.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AutoHub.Api.Controllers.Lookups
{
    [Route("api/locations")]
    public class LocationsController : LookupsControllerBase<Location>
    {
        public LocationsController(ILookupService<Location> service) : base(service)
        {
        }
    }
}