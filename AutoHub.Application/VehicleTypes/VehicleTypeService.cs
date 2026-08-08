using AutoHub.Application.Common.Exceptions;
using AutoHub.Application.Common.Interfaces;
using AutoHub.Application.Common.Utilities;
using AutoHub.Domain.Entities.Vehicles;
using Microsoft.EntityFrameworkCore;

namespace AutoHub.Application.VehicleTypes
{
    public class VehicleTypeService : IVehicleTypeService
    {
        private readonly IApplicationDbContext _context;

        public VehicleTypeService(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<VehicleTypeDto>> GetAllAsync(bool activeOnly, CancellationToken cancellationToken)
        {
            var query = _context.VehicleTypes.AsNoTracking();

            if (activeOnly)
            {
                query = query.Where(vt => vt.IsActive);
            }

            return await query
                .OrderBy(vt => vt.Name)
                .Select(vt => new VehicleTypeDto { Id = vt.Id, Name = vt.Name, Slug = vt.Slug, IsActive = vt.IsActive })
                .ToListAsync(cancellationToken);
        }

        public async Task<VehicleTypeDto?> GetByIdAsync(int id, CancellationToken cancellationToken)
        {
            return await _context.VehicleTypes
                .AsNoTracking()
                .Where(vt => vt.Id == id)
                .Select(vt => new VehicleTypeDto { Id = vt.Id, Name = vt.Name, Slug = vt.Slug, IsActive = vt.IsActive })
                .SingleOrDefaultAsync(cancellationToken);
        }

        public async Task<int> CreateAsync(string name, CancellationToken cancellationToken)
        {
            var normalizedName = name.Trim();
            var slug = SlugGenerator.GenerateSlug(normalizedName);

            if (await _context.VehicleTypes.AnyAsync(vt => vt.Name.ToLower() == normalizedName.ToLower(), cancellationToken))
            {
                throw new ValidationException("Name", "A vehicle type with this name already exists.");
            }

            if (await _context.VehicleTypes.AnyAsync(vt => vt.Slug == slug, cancellationToken))
            {
                throw new ValidationException("Name", "A vehicle type producing the same slug already exists.");
            }

            var entity = new VehicleType { Name = normalizedName, Slug = slug, IsActive = true };

            _context.VehicleTypes.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);

            return entity.Id;
        }

        public async Task UpdateAsync(int id, string name, bool isActive, CancellationToken cancellationToken)
        {
            var entity = await _context.VehicleTypes.FindAsync(new object[] { id }, cancellationToken)
                ?? throw new KeyNotFoundException($"VehicleType with id {id} not found.");

            var normalizedName = name.Trim();

            if (await _context.VehicleTypes.AnyAsync(
                vt => vt.Id != id && vt.Name.ToLower() == normalizedName.ToLower(), cancellationToken))
            {
                throw new ValidationException("Name", "A vehicle type with this name already exists.");
            }

            entity.Name = normalizedName;
            entity.IsActive = isActive;
            // Slug остава непроменен при update — вероятно вече е reference-нат
            // от frontend routes; преименуване на Name не бива да го чупи.

            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}