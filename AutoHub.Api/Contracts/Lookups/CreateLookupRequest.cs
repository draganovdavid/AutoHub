using System.ComponentModel.DataAnnotations;

namespace AutoHub.Api.Contracts.Lookups
{
    public class CreateLookupRequest
    {
        [Required]
        [StringLength(200)]
        public string Name { get; set; } = null!;
    }
}