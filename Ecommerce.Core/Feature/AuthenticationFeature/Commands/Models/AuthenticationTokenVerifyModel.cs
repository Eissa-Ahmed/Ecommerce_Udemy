namespace Ecommerce.Application.Feature.AuthenticationFeature.Commands.Models;

public sealed class AuthenticationTokenVerifyModel(string Token, string Email) : IRequest<ApplicationResponse<string>>
{
    public string Email { get; set; } = Email;
    public string Token { get; set; } = Token;
}
