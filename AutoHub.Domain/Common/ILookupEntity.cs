namespace AutoHub.Domain.Common
{
    public interface ILookupEntity
    {
        int Id { get; }
        string Name { get; set; }
        bool IsActive { get; set; }
    }
}