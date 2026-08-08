using AutoHub.Application.Common.Interfaces;
using AutoHub.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AutoHub.Api.Controllers.Lookups
{
    [Route("api/colors")]
    public class ColorsController : LookupsControllerBase<Color>
    {
        public ColorsController(ILookupService<Color> service) : base(service)
        {
        }
    }
}