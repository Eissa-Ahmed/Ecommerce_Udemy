namespace Ecommerce.Domain.Entities;

public sealed class Category
{
    public Category()
    {
        SubCategories = new List<SubCategory>();
        Products = new List<Product>();
    }
    public string Name { get; set; } = null!;
    public ICollection<SubCategory> SubCategories { get; set; }
    public ICollection<Product> Products { get; set; }

}

