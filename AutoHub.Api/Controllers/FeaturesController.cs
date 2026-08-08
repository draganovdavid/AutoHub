using AutoHub.Api.Contracts.Features;
using AutoHub.Application.Features;
using Microsoft.AspNetCore.Mvc;

namespace AutoHub.Api.Controllers
{
    [ApiController]
    [Route("api/features")]
    public class FeaturesController : ControllerBase
    {
        private readonly IFeatureService _service;

        public FeaturesController(IFeatureService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<List<FeatureDto>>> GetAll([FromQuery] bool activeOnly = true,
            CancellationToken cancellationToken = default)
            => Ok(await _service.GetAllAsync(activeOnly, cancellationToken));

        [HttpGet("{id:int}")]
        public async Task<ActionResult<FeatureDto>> GetById(int id, CancellationToken cancellationToken)
        {
            var result = await _service.GetByIdAsync(id, cancellationToken);
            return result is null ? NotFound() : Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<int>> Create(
            [FromBody] CreateFeatureRequest request, CancellationToken cancellationToken)
        {
            var id = await _service.CreateAsync(request.Name, request.FeatureCategoryId, cancellationToken);
            return CreatedAtAction(nameof(GetById), new { id }, id);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(
            int id, [FromBody] UpdateFeatureRequest request, CancellationToken cancellationToken)
        {
            await _service.UpdateAsync(id, request.Name, request.FeatureCategoryId, request.IsActive, cancellationToken);
            return NoContent();
        }
    }
}