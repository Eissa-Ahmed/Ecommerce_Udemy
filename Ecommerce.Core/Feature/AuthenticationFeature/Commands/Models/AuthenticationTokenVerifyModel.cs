namespace Ecommerce.Application.Feature.AuthenticationFeature.Commands.Models;

public sealed class AuthenticationTokenVerifyModel : IRequest<ApplicationResponse<string>>
{
    public string Email { get; set; } = null!;
    public string Token { get; set; } = null!;
}
