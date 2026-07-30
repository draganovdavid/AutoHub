using AutoHub.Domain.Common;

namespace AutoHub.Domain.Entities.Features
{
    public class Feature : BaseEntity<int>
    {
        public string Name { get; set; } = null!;

        public bool IsActive { get; set; } = true;

        public int FeatureCategoryId { get; set; }
        public FeatureCategory FeatureCategory { get; set; } = null!;

        public ICollection<VehicleTypeFeature> VehicleTypeFeatures { get; set; }
            = new List<VehicleTypeFeature>();

        public ICollection<VehicleSelectedFeature> SelectedFeatures { get; set; }
            = new List<VehicleSelectedFeature>();
    }
}