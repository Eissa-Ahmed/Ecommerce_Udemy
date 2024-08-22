namespace Ecommerce.Domain.Entities;

public sealed class Subscription
{
    public Subscription()
    {
        Id = Guid.NewGuid().ToString();
        StartDate = DateTime.UtcNow;
    }
    public string Id { get; set; }
    public string UserId { get; set; } = null!;
    public DateTime StartDate { get; set; }
    public User User { get; set; } = null!;
}
