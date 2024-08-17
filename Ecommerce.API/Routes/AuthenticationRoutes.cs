namespace Ecommerce.API.Routes;

public static class AuthenticationRoutes
{
    private const string Base = "api/v{version:apiVersion}/authentication";
    public const string Login = Base + "/login";
    public const string Register = Base + "/register";
    public const string RefreshToken = Base + "/token";
    public const string RevokeToken = Base + "/revoke";
    public const string ForgetPassword = Base + "/forget-password";
    public const string ResetPassword = Base + "/reset-password";
    public const string TokenVerify = Base + "/token-verify";

}

