namespace AutoHub.Application.Features
{
    public class FeatureDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool IsActive { get; set; }
        public int FeatureCategoryId { get; set; }
        public string FeatureCategoryName { get; set; } = null!;
    }
}