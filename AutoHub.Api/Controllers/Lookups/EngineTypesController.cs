using AutoHub.Application.Common.Interfaces;
using AutoHub.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AutoHub.Api.Controllers.Lookups
{
    [Route("api/engine-types")]
    public class EngineTypesController : LookupsControllerBase<EngineType>
    {
        public EngineTypesController(ILookupService<EngineType> service) : base(service)
        {
        }
    }
}