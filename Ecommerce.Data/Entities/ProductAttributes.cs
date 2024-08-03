namespace Ecommerce.Domain.Entities;

public sealed class ProductAttributes
{
    public ProductAttributes()
    {
        Id = Guid.NewGuid().ToString();
    }
    public string Id { get; set; } = null!;
    public string ProductId { get; set; } = null!;
    public Product Product { get; set; } = null!;
    public string AttributeId { get; set; } = null!;
    public Attributes Attributes { get; set; } = null!;
    public string Value { get; set; } = null!;
}

