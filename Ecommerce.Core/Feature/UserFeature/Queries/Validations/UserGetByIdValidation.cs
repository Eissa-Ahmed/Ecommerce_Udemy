namespace Ecommerce.Application.Feature.UserFeature.Queries.Validations;

public sealed class UserGetByIdValidation : AbstractValidator<UserGetByIdModel>
{
    private readonly UserManager<User> _userManager;

    public UserGetByIdValidation(UserManager<User> userManager)
    {
        _userManager = userManager;
        ApplyValidation();
    }

    private void ApplyValidation()
    {
        RuleFor(i => i.Id)
            .NotEmpty()
            .WithMessage("Id is required")
            .MustAsync(async (id, cancellation) => await _userManager
                .FindByIdAsync(id) is not null);
    }
}
