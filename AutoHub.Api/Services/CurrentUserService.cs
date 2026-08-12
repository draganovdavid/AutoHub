using System.IdentityModel.Tokens.Jwt;
using AutoHub.Application.Common.Interfaces;

namespace AutoHub.Api.Services
{
    public class CurrentUserService : ICurrentUserService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CurrentUserService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public Guid? UserId
        {
            get
            {
                var value = _httpContextAccessor.HttpContext?.User
                    .FindFirst(JwtRegisteredClaimNames.Sub)?.Value;

                return Guid.TryParse(value, out var id) ? id : null;
            }
        }
    }
}