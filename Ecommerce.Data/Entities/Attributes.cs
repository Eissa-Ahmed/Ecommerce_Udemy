namespace Ecommerce.Domain.Entities;

public class Attributes
{
    public Attributes()
    {
        Id = Guid.NewGuid().ToString();
        CategoryAttributes = new List<CategoryAttributes>();
        Categories = new List<Category>();
    }
    public string Id { get; set; } = null!;
    public string Name { get; set; } = null!;
    public ICollection<CategoryAttributes> CategoryAttributes { get; set; }
    public ICollection<Category> Categories { get; set; }
}

