namespace Ecommerce.Domain.Models;

public sealed class EmailSettings
{
    public string host { get; set; } = null!;
    public int port { get; set; }
    public string fromEmail { get; set; } = null!;
    public string fromName { get; set; } = null!;
    public string password { get; set; } = null!;
}
