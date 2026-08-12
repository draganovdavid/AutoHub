using AutoHub.Domain.Enums;
using FluentValidation;

namespace AutoHub.Application.Auth.Commands.Register
{
    public class RegisterCommandValidator : AbstractValidator<RegisterCommand>
    {
        public RegisterCommandValidator()
        {
            RuleFor(x => x.Email).NotEmpty().EmailAddress();
            RuleFor(x => x.Password).NotEmpty().MinimumLength(8);

            RuleFor(x => x.CompanyName)
                .Must((command, companyName) =>
                {
                    var isBlank = string.IsNullOrWhiteSpace(companyName);

                    return command.SellerType switch
                    {
                        SellerType.Dealer => !isBlank,
                        SellerType.Individual => isBlank,
                        _ => true
                    };
                })
                .WithMessage(x => x.SellerType == SellerType.Dealer
                    ? "Company name is required for dealer accounts."
                    : "Company name must not be set for individual accounts.");
        }
    }
}