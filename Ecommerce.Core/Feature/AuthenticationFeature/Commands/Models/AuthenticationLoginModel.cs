namespace Ecommerce.Application.Feature.AuthenticationFeature.Commands.Models;

public sealed class AuthenticationLoginModel : IRequest<ApplicationResponse<AuthenticationLoginResult>>
{
    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;
}
