namespace Ecommerce.Domain.Entities;

public sealed class ProductSizes
{
    public ProductSizes()
    {
        Id = Guid.NewGuid().ToString();
    }
    public string Id { get; set; } = null!;
    public string Size { get; set; } = null!;
    public int Count { get; set; }
    public string ProductId { get; set; } = null!;
    public Product Product { get; set; } = null!;
}