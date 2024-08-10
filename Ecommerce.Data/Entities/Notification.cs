namespace Ecommerce.Domain.Entities;

public sealed class Notification
{
    public Notification()
    {
        Id = Guid.NewGuid().ToString();
        DateSent = DateTime.UtcNow;
    }
    public string Id { get; set; }
    public string UserId { get; set; } = null!;
    public User User { get; set; } = null!;
    public NotificationType NotificationType { get; set; }
    public string Message { get; set; } = null!;
    public bool IsRead { get; set; } = false;
    public DateTime DateSent { get; set; }
}