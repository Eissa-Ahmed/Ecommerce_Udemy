namespace Ecommerce.Domain.Entities;

public class Attributes
{

    public string Name { get; set; } = null!;
    public string SubCategoryName { get; set; } = null!;
    public SubCategory SubCategory { get; set; } = null!;
}

