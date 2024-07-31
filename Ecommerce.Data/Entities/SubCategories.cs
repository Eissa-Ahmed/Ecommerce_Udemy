namespace Ecommerce.Domain.Entities;

public sealed class SubCategories
{
    public SubCategories()
    {
        Attributes = new List<Attributes>();
        SubCategorys = new List<SubCategories>();
    }
    public string Name { get; set; } = null!;
    public string ParentSubcategoryName { get; set; } = null!;
    public ICollection<Attributes> Attributes { get; set; }
    public SubCategories ParentSubcategory { get; set; } = null!;
    public ICollection<SubCategories> SubCategorys { get; set; }
    public string CategoryName { get; set; } = null!;
    public Categories Category { get; set; } = null!;

}
