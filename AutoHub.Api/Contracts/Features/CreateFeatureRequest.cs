using System.ComponentModel.DataAnnotations;

namespace AutoHub.Api.Contracts.Features
{
    public record CreateFeatureRequest(
        [Required, StringLength(150)] string Name,
        int FeatureCategoryId);
}