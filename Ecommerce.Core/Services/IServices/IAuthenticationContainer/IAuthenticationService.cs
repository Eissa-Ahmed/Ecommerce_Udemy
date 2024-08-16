namespace Ecommerce.Application.Services.IServices.IAuthenticationContainer;

public interface IAuthenticationService
{
    Task<string?> RegisterAsync(RegisterModel model);
    Task<AuthenticationModel> LoginAsync(LoginModel model);
    Task<AuthenticationModel> RefreshTokenAsync();
    Task<bool> RevokeTokenAsync();

}
