using System.ComponentModel.DataAnnotations;
using AutoHub.Domain.Enums;

namespace AutoHub.Api.Contracts.Auth
{
    public record RegisterRequest(
         [Required, EmailAddress] string Email,
         [Required, MinLength(8)] string Password,
         SellerType SellerType,
         string? CompanyName);
}