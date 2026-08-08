using AutoHub.Application.Common.Interfaces;
using AutoHub.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AutoHub.Api.Controllers.Lookups
{
    [Route("api/euro-standards")]
    public class EuroStandardsController : LookupsControllerBase<EuroStandard>
    {
        public EuroStandardsController(ILookupService<EuroStandard> service) : base(service)
        {
        }
    }
}