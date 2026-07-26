using AutoHub.Domain.Common;
using AutoHub.Domain.Entities.Features;

namespace AutoHub.Domain.Entities
{
    public class Feature : BaseEntity<int>
    {
        public string Name { get; set; } = null!;


        public int FeatureCategoryId { get; set; }

        public FeatureCategory FeatureCategory { get; set; } = null!;


        public ICollection<VehicleTypeFeature> VehicleTypeFeatures { get; set; }
            = new List<VehicleTypeFeature>();
    }
}