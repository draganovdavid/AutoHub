using AutoHub.Application.Common.Models;
using AutoHub.Domain.Common;

namespace AutoHub.Application.Common.Interfaces
{
    public interface ILookupService<TEntity> where TEntity : class, ILookupEntity
    {
        Task<List<LookupDto>> GetAllAsync(bool activeOnly, CancellationToken cancellationToken);
        Task<LookupDto?> GetByIdAsync(int id, CancellationToken cancellationToken);
        Task<int> CreateAsync(string name, CancellationToken cancellationToken);
        Task UpdateAsync(int id, string name, bool isActive, CancellationToken cancellationToken);
    }
}