namespace Ecommerce.Domain.Entities;

public sealed class Cart
{
    public Cart()
    {
        CartItems = new List<CartItem>();
        DateCreated = DateTime.UtcNow;
    }
    public string Id { get; set; } = null!;
    public string UserId { get; set; } = null!;
    public User User { get; set; } = null!;
    public DateTime DateCreated { get; set; }
    public ICollection<CartItem> CartItems { get; set; }
}
