using AutoHub.Domain.Common;

namespace AutoHub.Domain.Entities.Features
{
    public class FeatureCategory : BaseEntity<int>, ILookupEntity
    {
        public string Name { get; set; } = null!;

        public bool IsActive { get; set; } = true;

        public ICollection<Feature> Features { get; set; } = new List<Feature>();
    }
}