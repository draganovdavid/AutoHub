using AutoHub.Application.Common.Models;
using MediatR;

namespace AutoHub.Application.Auth.Commands.Login
{
    public record LoginCommand(string Email, string Password) : IRequest<AuthResultDto>;
}