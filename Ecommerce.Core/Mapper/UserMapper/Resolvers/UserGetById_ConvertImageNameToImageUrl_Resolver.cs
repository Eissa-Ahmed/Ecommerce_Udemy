namespace Ecommerce.Application.Mapper.UserMapper.Resolvers;

public sealed class UserGetById_ConvertImageNameToImageUrl_Resolver : IValueResolver<User, UserGetByIdResult, string?>
{
    private readonly IOptions<ApplicationSettingModel> _settings;

    public UserGetById_ConvertImageNameToImageUrl_Resolver(IOptions<ApplicationSettingModel> settings)
    {
        _settings = settings;
    }

    public string? Resolve(User source, UserGetByIdResult destination, string? destMember, ResolutionContext context)
    {
        return source.ImageName is null ? null : $"{_settings.Value.ApiUrl}/{source.ImageName}";
    }
}
