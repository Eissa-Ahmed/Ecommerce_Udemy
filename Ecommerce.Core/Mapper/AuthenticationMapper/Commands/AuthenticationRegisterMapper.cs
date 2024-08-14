namespace Ecommerce.Application.Mapper.AuthenticationMapper;

public partial class AuthenticationProfile
{
    private void ApplyAuthenticationRegisterMapper()
    {
        CreateMap<AuthenticationRegisterModel, RegisterModel>();
    }
}
