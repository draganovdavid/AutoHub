using AutoHub.Domain.Common;

namespace AutoHub.Domain.Entities
{
    public class Color : BaseEntity<int>, ILookupEntity
    {
        public string Name { get; set; } = null!;

        public bool IsActive { get; set; } = true;
    }
}