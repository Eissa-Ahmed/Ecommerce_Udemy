namespace Ecommerce.Domain.Entities;

public class ProductTag
{
    public ProductTag()
    {
        Id = Guid.NewGuid().ToString();
        Products = new List<Product>();
        ProductTagMappings = new List<ProductTagMapping>();
    }
    public string Id { get; set; }
    public string TagName { get; set; } = null!;
    public ICollection<ProductTagMapping> ProductTagMappings { get; set; }
    public ICollection<Product> Products { get; set; }
}