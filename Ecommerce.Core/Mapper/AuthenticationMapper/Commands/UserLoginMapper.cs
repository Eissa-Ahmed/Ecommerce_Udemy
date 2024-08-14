namespace Ecommerce.Application.Mapper.AuthenticationMapper;

public partial class AuthenticationProfile
{
    private void ApplyAuthenticationLoginMapper()
    {
        CreateMap<AuthenticationLoginModel, LoginModel>();
        CreateMap<AuthenticationModel, AuthenticationLoginResult>();
    }
}
