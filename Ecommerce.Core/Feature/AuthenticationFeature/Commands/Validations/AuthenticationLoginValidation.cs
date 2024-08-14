namespace Ecommerce.Application.Feature.AuthenticationFeature.Commands.Validations;

public sealed class AuthenticationLoginValidation : AbstractValidator<AuthenticationLoginModel>
{
    private readonly UserManager<User> _userManager;

    public AuthenticationLoginValidation(UserManager<User> userManager)
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
            .WithMessage("Invalid email address");

        RuleFor(x => x.Password)
            .NotEmpty()
            .WithMessage("Password is required");
    }
}
