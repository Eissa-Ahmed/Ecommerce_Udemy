namespace Ecommerce.Application.Feature.UserFeature.Commands.Handler;

public sealed class UserCommandHandler : ResponseHandler,
    IRequestHandler<UserSubscriptionModel, ApplicationResponse<string>>
{
    private readonly IUserService _userService;
    public UserCommandHandler(IUserService userService)
    {
        _userService = userService;
    }
    public async Task<ApplicationResponse<string>> Handle(UserSubscriptionModel request, CancellationToken cancellationToken)
    {
        await _userService.UserSubscriptionAsync(request.Email);
        return Success();
    }
}
