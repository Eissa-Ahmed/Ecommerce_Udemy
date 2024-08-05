namespace Ecommerce.Domain.Entities;

public sealed class Category
{
    public Category()
    {
        Id = Guid.NewGuid().ToString();
        SubCategories = new List<Category>();
        CategoryAttributes = new List<CategoryAttributes>();
        Attributes = new List<Attributes>();
        Products = new List<Product>();
    }
    public string Id { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string? ParentCategoryId { get; set; } = null;
    public Category? ParentCategory { get; set; } = null;
    public ICollection<Category> SubCategories { get; set; }
    public ICollection<CategoryAttributes> CategoryAttributes { get; set; }
    public ICollection<Attributes> Attributes { get; set; }
    public ICollection<Product> Products { get; set; }

    /* [Timestamp]
     public byte[] RowVersion { get; set; } = null!;*/
}

