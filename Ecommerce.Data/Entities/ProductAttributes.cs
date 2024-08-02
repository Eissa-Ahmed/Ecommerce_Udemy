namespace Ecommerce.Domain.Entities;

public sealed class ProductAttributes
{
    public string ProductId { get; set; } = null!;
    public Product Product { get; set; } = null!;
    public string AttributeName { get; set; } = null!;
    public string Value { get; set; } = null!;
}

