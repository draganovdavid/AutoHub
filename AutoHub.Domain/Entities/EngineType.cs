using AutoHub.Domain.Common;

namespace AutoHub.Domain.Entities
{
    public class EngineType : BaseEntity<int>
    {
        public string Name { get; set; } = null!;
    }
}