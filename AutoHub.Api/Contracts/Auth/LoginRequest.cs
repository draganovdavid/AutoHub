using System.ComponentModel.DataAnnotations;

namespace AutoHub.Api.Contracts.Auth
{
    public record LoginRequest(
        [Required] string Email,
        [Required] string Password);
}
