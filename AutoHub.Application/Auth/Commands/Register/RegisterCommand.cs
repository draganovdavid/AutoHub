using AutoHub.Application.Common.Models;
using AutoHub.Domain.Enums;
using MediatR;

namespace AutoHub.Application.Auth.Commands.Register
{
    public record RegisterCommand(
        string Email,
        string Password,
        SellerType SellerType,
        string? CompanyName
    ) : IRequest<AuthResultDto>;
}