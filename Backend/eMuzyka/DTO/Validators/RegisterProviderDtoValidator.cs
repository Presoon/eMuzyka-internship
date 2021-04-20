using System;
using System.Linq;
using eMuzyka.Infrastructure.Database;
using eMuzyka.DTO.Provider;
using FluentValidation;


namespace eMuzyka.DTO.Validators
{
    public class RegisterProviderDtoValidator : AbstractValidator<RegisterProviderDto>
    {
        public RegisterProviderDtoValidator(DatabaseContext dbContext)
        {
            RuleFor(x => x.Email)
                .NotEmpty()
                .EmailAddress();
            RuleFor(x => x.Password)
                .MinimumLength(6);
            RuleFor(x => x.ConfirmPassword).Equal(e => e.Password);

            RuleFor(x => x.Email)
                .Custom((value, context) =>
                {
                    var emailInUse = dbContext.Providers.Any(x => x.Email == value);

                    if (emailInUse)
                    {
                        context.AddFailure("Email", "This email already belongs to an existing provider!");
                    }
                });
        }
    }
}
