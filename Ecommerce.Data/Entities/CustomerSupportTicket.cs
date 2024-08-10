namespace Ecommerce.Domain.Entities;

public class CustomerSupportTicket
{
    public CustomerSupportTicket()
    {
        Id = Guid.NewGuid().ToString();
        DateCreated = DateTime.UtcNow;
        Status = TicketStatus.Active;
    }
    public string Id { get; set; }
    public string UserId { get; set; } = null!;
    public User User { get; set; } = null!;
    public string Subject { get; set; } = null!;
    public string Description { get; set; } = null!;
    public TicketStatus Status { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime? DateResolved { get; set; } = null;
}