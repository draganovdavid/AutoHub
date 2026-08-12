using AutoHub.Application.Common.Models;
using AutoHub.Domain.Enums;

namespace AutoHub.Application.Common.Interfaces
{
    public interface IIdentityService
    {
        Task<(bool Succeeded, Guid? UserId, IEnumerable<string> Errors)> CreateUserAsync(
            string email, string password, SellerType sellerType, string? companyName);

        Task<(bool Succeeded, Guid? UserId)> ValidateCredentialsAsync(string email, string password);

        Task<UserInfoDto?> GetUserInfoAsync(Guid userId);
    }
}