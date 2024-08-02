namespace Ecommerce.Domain.Entities;

public sealed class Category
{
    public Category()
    {
        SubCategories = new List<Category>();
        Attributes = new List<Attributes>();
        Products = new List<Product>();
    }
    public string Name { get; set; } = null!;
    public string? ParentCategoryName { get; set; } = null;
    public Category? ParentCategory { get; set; } = null;
    public ICollection<Category> SubCategories { get; set; }
    public ICollection<Attributes> Attributes { get; set; }
    public ICollection<Product> Products { get; set; }

}

