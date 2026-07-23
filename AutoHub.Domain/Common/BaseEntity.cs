namespace AutoHub.Domain.Common
{
    public abstract class BaseEntity<TKey>
    {
        public TKey Id { get; init; } = default!;
    }
}