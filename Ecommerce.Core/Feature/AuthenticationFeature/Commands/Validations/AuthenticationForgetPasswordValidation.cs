namespace Ecommerce.Application.Feature.AuthenticationFeature.Commands.Validations;

public sealed class AuthenticationForgetPasswordValidation : AbstractValidator<AuthenticationForgetPasswordModel>
{
    private readonly UserManager<User> _userManager;

    public AuthenticationForgetPasswordValidation(UserManager<User> userManager)
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
                        return user is not null;
                    })
                    .WithMessage("Email not found");
    }
}
