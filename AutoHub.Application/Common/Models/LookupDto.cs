namespace AutoHub.Application.Common.Models
{
    public class LookupDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool IsActive { get; set; }
    }
}