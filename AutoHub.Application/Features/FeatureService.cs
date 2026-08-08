using AutoHub.Application.Common.Exceptions;
using AutoHub.Application.Common.Interfaces;
using AutoHub.Domain.Entities.Features;
using Microsoft.EntityFrameworkCore;

namespace AutoHub.Application.Features
{
    public class FeatureService : IFeatureService
    {
        private readonly IApplicationDbContext _context;

        public FeatureService(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<FeatureDto>> GetAllAsync(bool activeOnly, CancellationToken cancellationToken)
        {
            var query = _context.Features.AsNoTracking();

            if (activeOnly)
            {
                query = query.Where(f => f.IsActive);
            }

            return await query
                .OrderBy(f => f.Name)
                .Select(f => new FeatureDto
                {
                    Id = f.Id,
                    Name = f.Name,
                    IsActive = f.IsActive,
                    FeatureCategoryId = f.FeatureCategoryId,
                    FeatureCategoryName = f.FeatureCategory.Name
                })
                .ToListAsync(cancellationToken);
        }

        public async Task<FeatureDto?> GetByIdAsync(int id, CancellationToken cancellationToken)
        {
            return await _context.Features
                .AsNoTracking()
                .Where(f => f.Id == id)
                .Select(f => new FeatureDto
                {
                    Id = f.Id,
                    Name = f.Name,
                    IsActive = f.IsActive,
                    FeatureCategoryId = f.FeatureCategoryId,
                    FeatureCategoryName = f.FeatureCategory.Name
                })
                .SingleOrDefaultAsync(cancellationToken);
        }

        public async Task<int> CreateAsync(string name, int featureCategoryId, CancellationToken cancellationToken)
        {
            var normalizedName = name.Trim();

            if (!await _context.FeatureCategories.AnyAsync(fc => fc.Id == featureCategoryId, cancellationToken))
            {
                throw new ValidationException("FeatureCategoryId", "Selected feature category does not exist.");
            }

            if (await _context.Features.AnyAsync(
                f => f.FeatureCategoryId == featureCategoryId && f.Name.ToLower() == normalizedName.ToLower(),
                cancellationToken))
            {
                throw new ValidationException("Name", "A feature with this name already exists in the selected category.");
            }

            var entity = new Feature { Name = normalizedName, FeatureCategoryId = featureCategoryId, IsActive = true };

            _context.Features.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);

            return entity.Id;
        }

        public async Task UpdateAsync(int id, string name, int featureCategoryId, bool isActive, CancellationToken cancellationToken)
        {
            var entity = await _context.Features.FindAsync(new object[] { id }, cancellationToken)
                ?? throw new KeyNotFoundException($"Feature with id {id} not found.");

            if (!await _context.FeatureCategories.AnyAsync(fc => fc.Id == featureCategoryId, cancellationToken))
            {
                throw new ValidationException("FeatureCategoryId", "Selected feature category does not exist.");
            }

            var normalizedName = name.Trim();

            if (await _context.Features.AnyAsync(
                f => f.Id != id && f.FeatureCategoryId == featureCategoryId && f.Name.ToLower() == normalizedName.ToLower(),
                cancellationToken))
            {
                throw new ValidationException("Name", "A feature with this name already exists in the selected category.");
            }

            entity.Name = normalizedName;
            entity.FeatureCategoryId = featureCategoryId;
            entity.IsActive = isActive;

            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}