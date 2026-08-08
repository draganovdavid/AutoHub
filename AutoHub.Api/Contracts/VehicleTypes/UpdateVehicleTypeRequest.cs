using System.ComponentModel.DataAnnotations;

namespace AutoHub.Api.Contracts.VehicleTypes
{
    public record UpdateVehicleTypeRequest([Required, StringLength(50)] string Name, bool IsActive);
}