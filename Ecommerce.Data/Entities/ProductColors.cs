namespace Ecommerce.Domain.Entities;

public sealed class ProductColors
{
    public ProductColors()
    {
        Id = Guid.NewGuid().ToString();
        ProductSizes = new List<ProductSizes>();
    }
    public string Id { get; set; } = null!;
    public string Color { get; set; } = null!;
    public int Count { get; set; }

    public string ProductId { get; set; } = null!;
    public Product Product { get; set; } = null!;
    public ICollection<ProductSizes> ProductSizes { get; set; }

}
