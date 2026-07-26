using AutoHub.Domain.Common;

namespace AutoHub.Domain.Entities
{
    public class Location : BaseEntity<int>
    {
        public string Name { get; set; } = null!;
    }
}