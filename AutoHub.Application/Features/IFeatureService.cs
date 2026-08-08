namespace AutoHub.Application.Features
{
    public interface IFeatureService
    {
        Task<List<FeatureDto>> GetAllAsync(bool activeOnly, CancellationToken cancellationToken);
        Task<FeatureDto?> GetByIdAsync(int id, CancellationToken cancellationToken);
        Task<int> CreateAsync(string name, int featureCategoryId, CancellationToken cancellationToken);
        Task UpdateAsync(int id, string name, int featureCategoryId, bool isActive, CancellationToken cancellationToken);
    }
}