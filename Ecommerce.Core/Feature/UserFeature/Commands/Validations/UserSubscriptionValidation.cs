namespace Ecommerce.Application.Feature.UserFeature.Commands.Validation;

public sealed class UserSubscriptionValidation : AbstractValidator<UserSubscriptionModel>
{
    private readonly UserManager<User> _userManager;
    private readonly IUserValidation _userValidation;

    public UserSubscriptionValidation(UserManager<User> userManager, IUserValidation userValidation)
    {
        _userManager = userManager;
        ApplyValidation();
        _userValidation = userValidation;
    }

    private void ApplyValidation()
    {
        RuleFor(i => i.Email)
            .NotEmpty()
            .WithMessage("Email is required")
            .NotNull()
            .WithMessage("Email is required")
            .MustAsync(async (email, cancellationToken) => await _userManager.FindByEmailAsync(email) != null)
            .WithMessage("Email is not registered")
            .MustAsync(EmailIsNotSubscribed)
            .WithMessage("Email is already subscribed");
    }

    private async Task<bool> EmailIsNotSubscribed(string arg1, CancellationToken token)
    {
        return !(await _userValidation.EmailIsSubscribed(arg1));
    }
}
