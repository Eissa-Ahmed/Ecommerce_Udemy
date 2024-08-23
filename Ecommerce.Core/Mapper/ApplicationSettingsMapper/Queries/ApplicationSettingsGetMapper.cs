namespace Ecommerce.Application.Mapper.ApplicationSettingsMapper;

public partial class ApplicationSettingsProfile
{
    private void ApplyApplicationSettingsGetMapper()
    {
        CreateMap<ApplicationSettings, ApplicationSettingsGetResult>()
            .ForMember(des => des.SocialMediaAccounts, opt => opt.MapFrom(src => src.SocialMediaAccounts));

        CreateMap<SocialMediaAccounts, ApplicationSettingsGetResult_SocialMediaAccounts>();

    }
}
