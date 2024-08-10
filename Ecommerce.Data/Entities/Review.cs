namespace Ecommerce.Domain.Entities;

public sealed class Review
{
    public Review()
    {
        Id = Guid.NewGuid().ToString();
        CreatedDate = DateTime.UtcNow;
    }
    public string Id { get; set; } = null!;
    public string ProductId { get; set; } = null!;
    public Product Product { get; set; } = null!;
    public string UserId { get; set; } = null!;
    public string Comment { get; set; } = null!;
    public int Rating { get; set; }
    public DateTime CreatedDate { get; set; }
    public User User { get; set; } = null!;
}
