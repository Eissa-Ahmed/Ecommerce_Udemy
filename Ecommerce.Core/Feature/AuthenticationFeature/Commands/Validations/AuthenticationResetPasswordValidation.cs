namespace Ecommerce.Application.Feature.AuthenticationFeature.Commands.Validations;

public sealed class AuthenticationResetPasswordValidation : AbstractValidator<AuthenticationResetPasswordModel>
{
    private readonly UserManager<User> _userManager;

    public AuthenticationResetPasswordValidation(UserManager<User> userManager)
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

        RuleFor(x => x.Password)
            .NotEmpty()
            .WithMessage("Password is required")
            .MinimumLength(6)
            .WithMessage("Password must be at least 6 characters long")
            .MaximumLength(25)
            .WithMessage("Password must be at most 25 characters long");

        RuleFor(x => x.Token)
            .NotEmpty()
            .WithMessage("Token is required");

    }
}
