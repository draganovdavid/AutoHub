namespace AutoHub.Domain.Entities
{
    public class Brand
    {
        public string Name { get; set; } = null!;

        public ICollection<VehicleModel> Models { get; set; } = new List<VehicleModel>();
    }
}