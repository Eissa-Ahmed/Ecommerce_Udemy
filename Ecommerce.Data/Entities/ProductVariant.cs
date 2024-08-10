namespace Ecommerce.Domain.Entities;

public sealed class ProductVariant
{
    public ProductVariant()
    {
        Id = Guid.NewGuid().ToString();
    }
    public string Id { get; set; }
    public string ProductId { get; set; } = null!;
    public string SKU { get; set; } = null!;
    public string Color { get; set; } = null!;
    public ProductSize Size { get; set; }
    public string Material { get; set; } = null!;
    public decimal Price { get; set; }
    public int StockQuantity { get; set; }

    public Product Product { get; set; } = null!;
}
