namespace Ecommerce.Domain.Entities;

public sealed class Review
{
    public Review()
    {
        CreatedDate = DateTime.UtcNow;
    }
    public string ProductId { get; set; } = null!;
    public Products Product { get; set; } = null!;
    public string UserId { get; set; } = null!;
    public string Comment { get; set; } = null!;
    public DateTime CreatedDate { get; set; }
}
