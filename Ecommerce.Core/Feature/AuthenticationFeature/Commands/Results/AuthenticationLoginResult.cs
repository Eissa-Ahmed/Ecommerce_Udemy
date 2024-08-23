namespace Ecommerce.Application.Feature.AuthenticationFeature.Commands.Results;

public sealed class AuthenticationLoginResult
{
    public string? Id { get; set; }
    public string? Email { get; set; }
    public bool IsAuthenticated { get; set; }
    public string? Message { get; set; }
    public string? Token { get; set; }
    public DateTime? TokenExpiration { get; set; }
    public string? RefreshToken { get; set; }
    public DateTime? RefreshTokenExpiration { get; set; }

}
