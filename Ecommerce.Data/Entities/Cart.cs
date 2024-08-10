namespace Ecommerce.Domain.Entities;

public sealed class Cart
{
    public Cart()
    {
        CartItems = new List<CartItem>();
    }
    public string Id { get; set; } = null!;
    public string UserId { get; set; } = null!;
    public List<CartItem> CartItems { get; set; }
}
