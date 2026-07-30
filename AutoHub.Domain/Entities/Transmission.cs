using AutoHub.Domain.Common;

namespace AutoHub.Domain.Entities
{
    public class Transmission : BaseEntity<int>
    {
        public string Name { get; set; } = null!;

        public bool IsActive { get; set; } = true;
    }
}