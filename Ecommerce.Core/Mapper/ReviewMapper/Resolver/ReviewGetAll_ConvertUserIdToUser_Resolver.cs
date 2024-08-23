namespace Ecommerce.Application.Mapper.ReviewMapper.Resolver;

public sealed class ReviewGetAll_ConvertUserIdToUser_Resolver : IValueResolver<Review, ReviewGetAllResult, ReviewGetAllResult_User>
{
    private readonly UserManager<User> _userManager;
    private readonly IOptions<ApplicationSettings> _applicationSettings;

    public ReviewGetAll_ConvertUserIdToUser_Resolver(UserManager<User> userManager, IOptions<ApplicationSettings> applicationSettings)
    {
        _userManager = userManager;
        _applicationSettings = applicationSettings;
    }

    public ReviewGetAllResult_User Resolve(Review source, ReviewGetAllResult destination, ReviewGetAllResult_User destMember, ResolutionContext context)
    {
        User? user = _userManager.FindByIdAsync(source.UserId).Result;
        return new ReviewGetAllResult_User
        {
            Emal = user!.Email!,
            UserImageUrl = $"{_applicationSettings.Value.UiUrl}{user!.ImageName}",
            Name = user!.UserName!
        };
    }
}
