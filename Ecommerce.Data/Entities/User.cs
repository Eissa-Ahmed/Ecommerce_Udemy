namespace Ecommerce.Domain.Entities;

public class User : IdentityUser
{
    public User()
    {
        Address = new List<Address>();
        Review = new List<Review>();
        Orders = new List<Order>();
        SupportTickets = new List<CustomerSupportTicket>();
        Notifications = new List<Notification>();
        AuditLog = new List<AuditLog>();
        RefreshToken = new List<RefreshToken>();
        Codes = new List<Codes>();
        DateCreated = DateTime.UtcNow;
    }
    public string? FirstName { get; set; } = null;
    public string? LastName { get; set; } = null;
    public string? ImageName { get; set; }
    public DateTime DateCreated { get; set; }

    public Cart? Cart { get; set; }
    public Wishlist? Wishlist { get; set; }
    public Subscription? Subscription { get; set; }

    public ICollection<Address> Address { get; set; }
    public ICollection<Review> Review { get; set; }
    public ICollection<Order> Orders { get; set; }
    public ICollection<CustomerSupportTicket> SupportTickets { get; set; }
    public ICollection<Notification> Notifications { get; set; }
    public ICollection<AuditLog> AuditLog { get; set; }
    public ICollection<RefreshToken> RefreshToken { get; set; }
    public ICollection<Codes> Codes { get; set; }
}
