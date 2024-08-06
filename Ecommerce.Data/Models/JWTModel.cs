namespace Ecommerce.Domain.Models;

public sealed class JWTModel
{
    public string Key { get; set; } = null!;
    public string Issuer { get; set; } = null!;
    public string Audience { get; set; } = null!;
    public int ExpireMinutes { get; set; }
    public int RefreshExpireMinutes { get; set; }
}
