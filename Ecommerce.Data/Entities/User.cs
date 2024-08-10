namespace Ecommerce.Domain.Entities;

public class User : IdentityUser
{
    public User()
    {
        Address = new List<Address>();
        Review = new List<Review>();
        Orders = new List<Order>();
        Wishlists = new List<Wishlist>();
        SupportTickets = new List<CustomerSupportTicket>();
        Notifications = new List<Notification>();
        AuditLog = new List<AuditLog>();
        DateCreated = DateTime.UtcNow;
    }
    public string? FirstName { get; set; } = null;
    public string? LastName { get; set; } = null;
    public string? ImageName { get; set; }
    public DateTime DateCreated { get; set; }
    public string? CartId { get; set; } = null;

    public Cart? Cart { get; set; }

    public ICollection<Address> Address { get; set; }
    public ICollection<Review> Review { get; set; }
    public ICollection<Order> Orders { get; set; }
    public ICollection<Wishlist> Wishlists { get; set; }
    public ICollection<CustomerSupportTicket> SupportTickets { get; set; }
    public ICollection<Notification> Notifications { get; set; }
    public ICollection<AuditLog> AuditLog { get; set; }
}
