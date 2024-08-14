namespace Ecommerce.Application.Mapper.AuthenticationMapper;

public partial class AuthenticationProfile : Profile
{
    public AuthenticationProfile()
    {
        ApplyAuthenticationLoginMapper();
        ApplyAuthenticationRegisterMapper();
    }
}
