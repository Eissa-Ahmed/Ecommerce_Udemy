namespace Ecommerce.Application.Services.IServices.IAuthenticationContainer;

public interface IAuthenticationService
{
    Task<string?> RegisterAsync(RegisterModel model);
    Task<AuthenticationModel> LoginAsync(LoginModel model);
    Task ForgotPasswordAsync(string email);
    Task<bool> TokenVerifyAsync(string email, string token);
    Task ResetPasswordAsync(string email, string password, string token);
    Task<AuthenticationModel> RefreshTokenAsync();
    Task<bool> RevokeTokenAsync();

}
