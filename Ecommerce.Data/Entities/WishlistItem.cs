namespace Ecommerce.Domain.Entities;

public class WishlistItem
{
    public WishlistItem()
    {
        Id = Guid.NewGuid().ToString();
    }
    public string Id { get; set; } = null!;
    public string WishlistId { get; set; } = null!;
    public Wishlist Wishlist { get; set; } = null!;
    public string ProductId { get; set; } = null!;
    public Product Product { get; set; } = null!;
}