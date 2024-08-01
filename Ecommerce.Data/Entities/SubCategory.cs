namespace Ecommerce.Domain.Entities;

public sealed class SubCategory
{
    public SubCategory()
    {
        Attributes = new List<Attributes>();
        SubCategorys = new List<SubCategory>();
    }
    public string Name { get; set; } = null!;
    public ICollection<Attributes> Attributes { get; set; }
    public ICollection<SubCategory> SubCategorys { get; set; }

    public string? ParentSubcategoryName { get; set; } = null;
    public SubCategory? ParentSubcategory { get; set; } = null;

    public string CategoryName { get; set; } = null!;
    public Category Category { get; set; } = null!;

}
