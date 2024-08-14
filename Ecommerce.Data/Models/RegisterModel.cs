namespace Ecommerce.Domain.Models;

public sealed class RegisterModel
{
    public string? FirstName { get; set; } = null;
    public string? LastName { get; set; } = null;
    public string Email { get; set; } = null!;
    public string UserName => Email.Substring(0, Email.IndexOf('@'));
    public string Password { get; set; } = null!;
}
