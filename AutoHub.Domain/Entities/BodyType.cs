using AutoHub.Domain.Common;

namespace AutoHub.Domain.Entities
{
    public class BodyType : BaseEntity<int>
    {
        public string Name { get; set; } = null!;
    }
}