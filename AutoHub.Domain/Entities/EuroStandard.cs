using AutoHub.Domain.Common;

namespace AutoHub.Domain.Entities
{
    public class EuroStandard : BaseEntity<int>
    {
        public string Name { get; set; } = null!;

        public bool IsActive { get; set; } = true;
    }
}