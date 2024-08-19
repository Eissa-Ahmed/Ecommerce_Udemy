namespace Ecommerce.Domain.Entities;

public class Tag
{
    public Tag()
    {
        Id = Guid.NewGuid().ToString();
        Products = new List<Product>();
        ProductTagMappings = new List<ProductTag>();
    }
    public string Id { get; set; }
    public string TagName { get; set; } = null!;
    public ICollection<ProductTag> ProductTagMappings { get; set; }
    public ICollection<Product> Products { get; set; }
}