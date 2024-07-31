namespace Ecommerce.Domain.Entities;

public sealed class Categories
{
    public Categories()
    {
        SubCategories = new List<SubCategories>();
        Products = new List<Products>();
    }
    public string Name { get; set; } = null!;
    public ICollection<SubCategories> SubCategories { get; set; }
    public ICollection<Products> Products { get; set; }

}

