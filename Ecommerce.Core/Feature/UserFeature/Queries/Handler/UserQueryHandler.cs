namespace Ecommerce.Application.Feature.UserFeature.Queries.Handler;

public sealed class UserQueryHandler : ResponseHandler,
    IRequestHandler<UserGetByIdModel, ApplicationResponse<UserGetByIdResult>>
{
    private readonly IUserService _userService;
    private readonly IMapper _mapper;
    public UserQueryHandler(IUserService userService, IMapper mapper)
    {
        _userService = userService;
        _mapper = mapper;
    }

    public async Task<ApplicationResponse<UserGetByIdResult>> Handle(UserGetByIdModel request, CancellationToken cancellationToken)
    {
        User user = await _userService.GetByIdAsync(request.Id);
        return Success(_mapper.Map<UserGetByIdResult>(user));
    }
}
