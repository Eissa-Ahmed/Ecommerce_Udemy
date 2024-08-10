namespace Ecommerce.Domain.Entities;

public sealed class Wishlist
{
    public Wishlist()
    {
        Id = Guid.NewGuid().ToString();
        WishlistItems = new List<WishlistItem>();
    }
    public string Id { get; set; } = null!;
    public string UserId { get; set; } = null!;
    public User User { get; set; } = null!;
    public ICollection<WishlistItem> WishlistItems { get; set; }
}
