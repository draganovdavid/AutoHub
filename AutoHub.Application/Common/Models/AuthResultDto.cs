namespace AutoHub.Application.Common.Models
{
    public class AuthResultDto
    {
        public string Token { get; set; } = null!;
        public DateTime ExpiresAtUtc { get; set; }
        public Guid UserId { get; set; }
        public string Email { get; set; } = null!;
    }
}