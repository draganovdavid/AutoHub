using AutoHub.Application.Common.Interfaces;
using AutoHub.Domain.Entities.Features;
using Microsoft.AspNetCore.Mvc;

namespace AutoHub.Api.Controllers.Lookups
{
    [Route("api/feature-categories")]
    public class FeatureCategoriesController : LookupsControllerBase<FeatureCategory>
    {
        public FeatureCategoriesController(ILookupService<FeatureCategory> service) : base(service) 
        {
        }
    }
}