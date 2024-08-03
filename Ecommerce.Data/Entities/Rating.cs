namespace Ecommerce.Domain.Entities;

public sealed class Rating
{
    public Rating()
    {
        Id = Guid.NewGuid().ToString();
        CreatedDate = DateTime.UtcNow;
    }
    public string Id { get; set; } = null!;
    public string ProductId { get; set; } = null!;
    public string UserId { get; set; } = null!;
    public Product Product { get; set; } = null!;
    public int Score { get; set; }
    public DateTime CreatedDate { get; set; }
}

