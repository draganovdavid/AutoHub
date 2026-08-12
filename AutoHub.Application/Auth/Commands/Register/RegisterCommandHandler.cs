using AutoHub.Application.Common.Exceptions;
using AutoHub.Application.Common.Interfaces;
using AutoHub.Application.Common.Models;
using MediatR;

namespace AutoHub.Application.Auth.Commands.Register
{
    public class RegisterCommandHandler : IRequestHandler<RegisterCommand, AuthResultDto>
    {
        private readonly IIdentityService _identityService;
        private readonly IJwtTokenGenerator _tokenGenerator;

        public RegisterCommandHandler(IIdentityService identityService, IJwtTokenGenerator tokenGenerator)
        {
            _identityService = identityService;
            _tokenGenerator = tokenGenerator;
        }

        public async Task<AuthResultDto> Handle(RegisterCommand request, CancellationToken cancellationToken)
        {
            var (succeeded, userId, errors) = await _identityService.CreateUserAsync(
                request.Email, request.Password, request.SellerType, request.CompanyName);

            if (!succeeded)
            {
                throw new ValidationException("Email", string.Join(" ", errors));
            }

            var token = _tokenGenerator.GenerateToken(
                userId!.Value, request.Email, request.SellerType, roles: Array.Empty<string>());

            return new AuthResultDto
            {
                Token = token.Token,
                ExpiresAtUtc = token.ExpiresAtUtc,
                UserId = userId.Value,
                Email = request.Email
            };
        }

    }
}
