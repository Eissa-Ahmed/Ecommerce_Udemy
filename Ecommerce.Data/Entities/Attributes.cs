namespace Ecommerce.Domain.Entities;

public class Attributes
{

    public string Name { get; set; } = null!;
    public string SubCategoryName { get; set; } = null!;
    public SubCategories SubCategory { get; set; } = null!;
}

