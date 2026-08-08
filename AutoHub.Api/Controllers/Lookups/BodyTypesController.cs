using AutoHub.Application.Common.Interfaces;
using AutoHub.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AutoHub.Api.Controllers.Lookups
{
    [Route("api/body-types")]
    public class BodyTypesController : LookupsControllerBase<BodyType>
    {
        public BodyTypesController(ILookupService<BodyType> service) : base(service)
        {
        }
    }
}