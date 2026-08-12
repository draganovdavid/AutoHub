using AutoHub.Application.Common.Exceptions;
using AutoHub.Application.Common.Interfaces;
using AutoHub.Application.Common.Models;
using MediatR;

namespace AutoHub.Application.Auth.Commands.Login
{
    public class LoginCommandHandler : IRequestHandler<LoginCommand, AuthResultDto>
    {
        private readonly IIdentityService _identityService;
        private readonly IJwtTokenGenerator _tokenGenerator;

        public LoginCommandHandler(IIdentityService identityService, IJwtTokenGenerator tokenGenerator)
        {
            _identityService = identityService;
            _tokenGenerator = tokenGenerator;
        }

        public async Task<AuthResultDto> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            var (succeeded, userId) = await _identityService.ValidateCredentialsAsync(request.Email, request.Password);

            if (!succeeded)
            {
                throw new AuthenticationException("Invalid email or password.");
            }

            var userInfo = await _identityService.GetUserInfoAsync(userId!.Value)
                ?? throw new AuthenticationException("Invalid email or password.");

            var token = _tokenGenerator.GenerateToken(
                userId.Value, userInfo.Email, userInfo.SellerType, roles: Array.Empty<string>());

            return new AuthResultDto
            {
                Token = token.Token,
                ExpiresAtUtc = token.ExpiresAtUtc,
                UserId = userId.Value,
                Email = userInfo.Email
            };
        }
    }
}