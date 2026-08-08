namespace AutoHub.Application.VehicleTypes
{
    public interface IVehicleTypeService
    {
        Task<List<VehicleTypeDto>> GetAllAsync(bool activeOnly, CancellationToken cancellationToken);
        Task<VehicleTypeDto?> GetByIdAsync(int id, CancellationToken cancellationToken);
        Task<int> CreateAsync(string name, CancellationToken cancellationToken);
        Task UpdateAsync(int id, string name, bool isActive, CancellationToken cancellationToken);
    }
}