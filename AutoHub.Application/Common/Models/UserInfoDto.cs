using AutoHub.Domain.Enums;

namespace AutoHub.Application.Common.Models
{
    public class UserInfoDto
    {
        public Guid Id { get; set; }
        public string Email { get; set; } = null!;
        public SellerType SellerType { get; set; }
        public string? CompanyName { get; set; }
    }
}