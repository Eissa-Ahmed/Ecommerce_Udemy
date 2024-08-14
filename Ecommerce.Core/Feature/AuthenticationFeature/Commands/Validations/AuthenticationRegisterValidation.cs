namespace Ecommerce.Application.Feature.AuthenticationFeature.Commands.Validations;

public sealed class AuthenticationRegisterValidation : AbstractValidator<AuthenticationRegisterModel>
{
    private readonly UserManager<User> _userManager;

    public AuthenticationRegisterValidation(UserManager<User> userManager)
    {
        _userManager = userManager;
        ApplyValidation();
    }

    private void ApplyValidation()
    {
        RuleFor(x => x.Email)
            .NotEmpty()
            .WithMessage("Email is required")
            .EmailAddress()
            .WithMessage("Invalid email address")
            .MustAsync(async (email, cancellation) =>
            {
                User? user = await _userManager.FindByEmailAsync(email);
                return user is null;
            })
            .WithMessage("Email already exists");

        RuleFor(x => x.FirstName)
            .Length(2, 25)
            .When(x => !string.IsNullOrEmpty(x.FirstName))
            .WithMessage("FirstName must be between 2 and 25 characters");

        RuleFor(x => x.LastName)
            .Length(2, 25)
            .When(x => !string.IsNullOrEmpty(x.FirstName))
            .WithMessage("LastName must be between 2 and 25 characters");


        RuleFor(x => x.Password)
            .NotEmpty()
            .WithMessage("Password is required");
    }
}
