using AutoHub.Api.Contracts.Lookups;
using AutoHub.Application.Common.Interfaces;
using AutoHub.Application.Common.Models;
using AutoHub.Domain.Common;
using Microsoft.AspNetCore.Mvc;

namespace AutoHub.Api.Controllers.Lookups
{
    [ApiController]
    public abstract class LookupsControllerBase<TEntity> : ControllerBase
        where TEntity : class, ILookupEntity
    {
        private readonly ILookupService<TEntity> _service;

        protected LookupsControllerBase(ILookupService<TEntity> service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<List<LookupDto>>> GetAll(
            [FromQuery] bool activeOnly = true,
            CancellationToken cancellationToken = default)
        {
            var allLookups = await _service.GetAllAsync(activeOnly, cancellationToken);

            return Ok(allLookups);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<LookupDto>> GetById(int id, CancellationToken cancellationToken)
        {
            var result = await _service.GetByIdAsync(id, cancellationToken);
            return result is null ? NotFound() : Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<int>> Create([FromBody] CreateLookupRequest request,
            CancellationToken cancellationToken)
        {
            var id = await _service.CreateAsync(request.Name, cancellationToken);
            return CreatedAtAction(nameof(GetById), new { id }, id);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(
            int id,
            [FromBody] UpdateLookupRequest request,
            CancellationToken cancellationToken)
        {
            await _service.UpdateAsync(id, request.Name, request.IsActive, cancellationToken);
            return NoContent();
        }
    }
}