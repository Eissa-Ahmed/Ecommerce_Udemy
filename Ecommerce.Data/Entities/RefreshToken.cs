namespace Ecommerce.Domain.Entities;

public class RefreshToken
{
    public RefreshToken()
    {
        Token = Guid.NewGuid().ToString();
        Created = DateTime.UtcNow;
    }
    public string UserId { get; set; } = null!;
    public string Token { get; set; } = null!;
    public DateTime Created { get; set; }
    public DateTime Expires { get; set; }
    public DateTime? Revoked { get; set; } = null;
    public bool IsExpired => DateTime.UtcNow >= Expires;
    public bool IsActive => Revoked == null && !IsExpired;
    public User User { get; set; } = null!;
}