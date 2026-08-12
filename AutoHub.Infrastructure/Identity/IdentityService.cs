using AutoHub.Application.Common.Interfaces;
using AutoHub.Application.Common.Models;
using AutoHub.Domain.Enums;
using Microsoft.AspNetCore.Identity;

namespace AutoHub.Infrastructure.Identity
{
    public class IdentityService : IIdentityService
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public IdentityService(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<(bool Succeeded, Guid? UserId, IEnumerable<string> Errors)> CreateUserAsync(
            string email, string password, SellerType sellerType, string? companyName)
        {
            var user = new ApplicationUser
            {
                Id = Guid.NewGuid(),
                UserName = email,
                Email = email,
                SellerType = sellerType,
                CompanyName = sellerType == SellerType.Dealer ? companyName?.Trim() : null
            };

            // UserManager хешира паролата (PBKDF2 по default) и enforce-ва
            // password policy-то, конфигурирано в AddIdentityCore.
            var result = await _userManager.CreateAsync(user, password);

            return result.Succeeded
                ? (true, user.Id, Array.Empty<string>())
                : (false, null, result.Errors.Select(e => e.Description));
        }

        public async Task<(bool Succeeded, Guid? UserId)> ValidateCredentialsAsync(string email, string password)
        {
            var user = await _userManager.FindByEmailAsync(email);

            if (user is null)
            {
                return (false, null);
            }

            var isValid = await _userManager.CheckPasswordAsync(user, password);

            return isValid ? (true, user.Id) : (false, null);
        }

        public async Task<UserInfoDto?> GetUserInfoAsync(Guid userId)
        {
            var user = await _userManager.FindByIdAsync(userId.ToString());

            return user is null
                ? null
                : new UserInfoDto
                {
                    Id = user.Id,
                    Email = user.Email!,
                    SellerType = user.SellerType,
                    CompanyName = user.CompanyName
                };
        }
    }
}