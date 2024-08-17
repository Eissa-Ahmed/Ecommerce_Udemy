namespace Ecommerce.Domain.Entities;

public sealed class Codes
{
    public Codes()
    {
        Id = Guid.NewGuid().ToString();
        DateCreated = DateTime.UtcNow;
        IsUsed = false;
    }
    public string Id { get; set; }
    public string Code { get; set; } = null!;
    public bool IsUsed { get; set; }
    public bool IsActive => !IsUsed && DateTime.UtcNow < DateCreated.AddMinutes(10) && Revoked == null;
    public DateTime DateCreated { get; set; }
    public DateTime? Revoked { get; set; } = null;
    public string UserId { get; set; } = null!;
    public User User { get; set; } = null!;
}
