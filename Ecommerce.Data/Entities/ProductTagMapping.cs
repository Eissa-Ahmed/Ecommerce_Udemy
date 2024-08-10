namespace Ecommerce.Domain.Entities;

public sealed class ProductTagMapping
{
    public ProductTagMapping()
    {
        Id = Guid.NewGuid().ToString();
    }
    public string Id { get; set; }
    public string ProductId { get; set; } = null!;
    public string TagId { get; set; } = null!;

    public Product Product { get; set; } = null!;
    public ProductTag Tag { get; set; } = null!;
}
