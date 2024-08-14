namespace Ecommerce.Domain.Models;

public sealed class LoginModel
{
    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;
}
