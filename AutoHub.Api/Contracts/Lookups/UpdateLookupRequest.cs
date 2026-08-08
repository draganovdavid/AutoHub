using System.ComponentModel.DataAnnotations;

namespace AutoHub.Api.Contracts.Lookups
{
    public class UpdateLookupRequest
    {
        [Required]
        [StringLength(200)]
        public string Name { get; set; } = null!;

        public bool IsActive { get; set; }
    }
}