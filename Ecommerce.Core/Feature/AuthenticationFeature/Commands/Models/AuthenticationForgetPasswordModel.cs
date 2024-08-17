namespace Ecommerce.Application.Feature.AuthenticationFeature.Commands.Models;

public sealed class AuthenticationForgetPasswordModel(string Email) : IRequest<ApplicationResponse<string>>
{
    public string Email { get; set; } = Email;
}
