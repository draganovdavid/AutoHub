using AutoHub.Application.Common.Exceptions;
using AutoHub.Application.Common.Interfaces;
using AutoHub.Application.Common.Models;
using AutoHub.Domain.Common;
using Microsoft.EntityFrameworkCore;

namespace AutoHub.Application.Common.Services
{
    public class LookupService<TEntity> : ILookupService<TEntity>
        where TEntity : class, ILookupEntity, new()
    {
        private readonly IApplicationDbContext _context;

        public LookupService(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<LookupDto>> GetAllAsync(bool activeOnly, CancellationToken cancellationToken)
        {
            var query = _context.Set<TEntity>().AsNoTracking();

            if (activeOnly)
            {
                query = query.Where(e => e.IsActive);
            }

            return await query
                .OrderBy(e => e.Name)
                .Select(e => new LookupDto { Id = e.Id, Name = e.Name, IsActive = e.IsActive })
                .ToListAsync(cancellationToken);
        }

        public async Task<LookupDto?> GetByIdAsync(int id, CancellationToken cancellationToken)
        {
            return await _context.Set<TEntity>()
                .AsNoTracking()
                .Where(e => e.Id == id)
                .Select(e => new LookupDto { Id = e.Id, Name = e.Name, IsActive = e.IsActive })
                .SingleOrDefaultAsync(cancellationToken);
        }

        public async Task<int> CreateAsync(string name, CancellationToken cancellationToken)
        {
            var normalized = name.Trim();

            await EnsureNameIsUniqueAsync(normalized, excludeId: null, cancellationToken);

            var entity = new TEntity { Name = normalized, IsActive = true };

            _context.Set<TEntity>().Add(entity);
            await _context.SaveChangesAsync(cancellationToken);

            return entity.Id;
        }

        public async Task UpdateAsync(int id, string name, bool isActive, CancellationToken cancellationToken)
        {
            var normalized = name.Trim();

            await EnsureNameIsUniqueAsync(normalized, excludeId: id, cancellationToken);

            var entity = await _context.Set<TEntity>().FindAsync(new object[] { id }, cancellationToken)
                ?? throw new KeyNotFoundException($"{typeof(TEntity).Name} with id {id} not found.");

            entity.Name = normalized;
            entity.IsActive = isActive;

            await _context.SaveChangesAsync(cancellationToken);
        }

        private async Task EnsureNameIsUniqueAsync(string normalizedName, int? excludeId, CancellationToken cancellationToken)
        {
            var query = _context.Set<TEntity>()
                .Where(e => e.Name == normalizedName);

            if (excludeId is not null)
            {
                query = query.Where(e => e.Id != excludeId.Value);
            }

            if (await query.AnyAsync(cancellationToken))
            {
                throw new ValidationException("Name", $"A {typeof(TEntity).Name} with this name already exists.");
            }
        }
    }
}