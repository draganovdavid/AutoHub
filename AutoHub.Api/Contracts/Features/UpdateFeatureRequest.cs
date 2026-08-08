using System.ComponentModel.DataAnnotations;

namespace AutoHub.Api.Contracts.Features
{
    public record UpdateFeatureRequest(
        [Required, StringLength(150)] string Name,
        int FeatureCategoryId,
        bool IsActive);
}