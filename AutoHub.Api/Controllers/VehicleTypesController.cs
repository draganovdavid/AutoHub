using AutoHub.Api.Contracts.VehicleTypes;
using AutoHub.Application.VehicleTypes;
using Microsoft.AspNetCore.Mvc;

namespace AutoHub.Api.Controllers
{
    [ApiController]
    [Route("api/vehicle-types")]
    public class VehicleTypesController : ControllerBase
    {
        private readonly IVehicleTypeService _service;

        public VehicleTypesController(IVehicleTypeService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<List<VehicleTypeDto>>> GetAll(
            [FromQuery] bool activeOnly = true, CancellationToken cancellationToken = default)
            => Ok(await _service.GetAllAsync(activeOnly, cancellationToken));

        [HttpGet("{id:int}")]
        public async Task<ActionResult<VehicleTypeDto>> GetById(int id, CancellationToken cancellationToken)
        {
            var result = await _service.GetByIdAsync(id, cancellationToken);
            return result is null ? NotFound() : Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<int>> Create(
            [FromBody] CreateVehicleTypeRequest request, CancellationToken cancellationToken)
        {
            var id = await _service.CreateAsync(request.Name, cancellationToken);
            return CreatedAtAction(nameof(GetById), new { id }, id);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(
            int id, [FromBody] UpdateVehicleTypeRequest request, CancellationToken cancellationToken)
        {
            await _service.UpdateAsync(id, request.Name, request.IsActive, cancellationToken);
            return NoContent();
        }
    }
}