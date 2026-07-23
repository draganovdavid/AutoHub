namespace AutoHub.Domain.Common
{
    public abstract class AuditableEntity<TKey> : BaseEntity<TKey>
    {
        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }

        public bool IsDeleted { get; set; }
    }
}