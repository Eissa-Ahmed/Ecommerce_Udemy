namespace Ecommerce.Domain.Entities;

public sealed class Favorite
{
    public Favorite()
    {
        CreatedDate = DateTime.UtcNow;
    }
    public string UserId { get; set; } = null!;
    public string ProductId { get; set; } = null!;
    public Product Product { get; set; } = null!;
    public DateTime CreatedDate { get; set; }
}
