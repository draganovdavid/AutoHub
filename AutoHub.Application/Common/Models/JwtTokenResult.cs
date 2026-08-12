namespace AutoHub.Application.Common.Models
{
    public record JwtTokenResult(string Token, DateTime ExpiresAtUtc);
}