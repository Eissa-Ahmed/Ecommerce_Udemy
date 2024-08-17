namespace Ecommerce.Application.Feature.AuthenticationFeature.Commands.Validations;

public sealed class AuthenticationTokenVerifyValidation : AbstractValidator<AuthenticationTokenVerifyModel>
{
    private readonly UserManager<User> _userManager;
    public AuthenticationTokenVerifyValidation(UserManager<User> userManager)
    {
        ApplyValidation();
        _userManager = userManager;
    }

    private void ApplyValidation()
    {
        RuleFor(x => x.Token)
                    .NotEmpty()
                    .WithMessage("Token is required");

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