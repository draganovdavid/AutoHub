using AutoHub.Application.Common.Models;
using AutoHub.Domain.Enums;

namespace AutoHub.Application.Common.Interfaces
{
    public interface IJwtTokenGenerator
    {
        JwtTokenResult GenerateToken(Guid userId, string email, SellerType sellerType, IEnumerable<string> roles);
    }
}