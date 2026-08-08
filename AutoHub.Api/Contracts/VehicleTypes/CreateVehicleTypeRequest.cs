using System.ComponentModel.DataAnnotations;

namespace AutoHub.Api.Contracts.VehicleTypes
{
    public record CreateVehicleTypeRequest([Required, StringLength(50)] string Name);
}