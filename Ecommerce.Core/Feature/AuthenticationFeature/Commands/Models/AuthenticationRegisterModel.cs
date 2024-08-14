namespace Ecommerce.Application.Feature.AuthenticationFeature.Commands.Models;

public sealed class AuthenticationRegisterModel : IRequest<ApplicationResponse<string>>
{
    public string? FirstName { get; set; } = null;
    public string? LastName { get; set; } = null;
    public string Email { get; set; } = null!;
    public string UserName => Email.Substring(0, Email.IndexOf('@'));
    public string Password { get; set; } = null!;
}
