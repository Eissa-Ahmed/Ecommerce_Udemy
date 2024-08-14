namespace Ecommerce.API.Routes;

public static class AuthenticationRoutes
{
    private const string Base = "api/v{version:apiVersion}/authentication";
    public const string Login = Base + "/login";
    public const string Register = Base + "/register";

}

