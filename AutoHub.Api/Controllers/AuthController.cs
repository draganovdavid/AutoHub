using AutoHub.Application.Auth.Commands.Login;
using AutoHub.Application.Auth.Commands.Register;
using AutoHub.Application.Common.Models;
using AutoHub.Api.Contracts.Auth;
using Microsoft.AspNetCore.Mvc;
using MediatR;

namespace AutoHub.Api.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController : ControllerBase
    {
        private readonly ISender _sender;

        public AuthController(ISender sender)
        {
            _sender = sender;
        }

        [HttpPost("register")]
        public async Task<ActionResult<AuthResultDto>> Register(
            [FromBody] RegisterRequest request, CancellationToken cancellationToken)
        {
            var result = await _sender.Send(
                new RegisterCommand(request.Email, request.Password, request.SellerType, request.CompanyName),
                cancellationToken);

            return Ok(result);
        }

        [HttpPost("login")]
        public async Task<ActionResult<AuthResultDto>> Login(
            [FromBody] LoginRequest request, CancellationToken cancellationToken)
        {
            var result = await _sender.Send(new LoginCommand(request.Email, request.Password), cancellationToken);

            return Ok(result);
        }
    }
}