namespace Ecommerce.Domain.Entities;

public sealed class Rating
{
    public Rating()
    {
        CreatedDate = DateTime.UtcNow;
    }
    public string ProductId { get; set; } = null!;
    public Products Product { get; set; } = null!;
    public string UserId { get; set; } = null!;
    public int Score { get; set; }
    public DateTime CreatedDate { get; set; }
}

