using AutoHub.Application.Common.Interfaces;
using AutoHub.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AutoHub.Api.Controllers.Lookups
{
    [Route("api/brands")]
    public class BrandsController : LookupsControllerBase<Brand>
    {
        public BrandsController(ILookupService<Brand> service) : base(service)
        {
        }
    }
}