namespace Ecommerce.Domain.Entities;

public sealed class AuditLog
{
    public AuditLog()
    {
        Id = Guid.NewGuid().ToString();
        DateLogged = DateTime.UtcNow;
    }
    public string Id { get; set; }
    public string UserID { get; set; } = null!;
    public string Action { get; set; } = null!;
    public string EntityName { get; set; } = null!;
    public string EntityId { get; set; } = null!;
    public DateTime DateLogged { get; set; }

    public User User { get; set; } = null!;
}