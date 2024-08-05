namespace Ecommerce.Domain.Entities;

public class Attributes
{
    public Attributes()
    {
        Id = Guid.NewGuid().ToString();
        ProductAttributes = new List<ProductAttributes>();
        CategoryAttributes = new List<CategoryAttributes>();
    }
    public string Id { get; set; } = null!;
    public string Name { get; set; } = null!;
    public ICollection<ProductAttributes> ProductAttributes { get; set; }
    public ICollection<CategoryAttributes> CategoryAttributes { get; set; }
}

