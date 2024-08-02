namespace Ecommerce.Application.Feature.CategoryFeature.Queries.Results;

public sealed class CategoryGetByIdResult
{
    public CategoryGetByIdResult()
    {
        SubCategories = new List<CategoryGetByIdResult_SubCategory>();
    }
    public string Name { get; set; } = null!;
    public List<CategoryGetByIdResult_SubCategory> SubCategories { get; set; }
}

public sealed class CategoryGetByIdResult_SubCategory
{
    public CategoryGetByIdResult_SubCategory()
    {
        SubCategories = new List<CategoryGetByIdResult_SubCategory>();
    }
    public string Name { get; set; } = null!;
    public List<CategoryGetByIdResult_SubCategory> SubCategories { get; set; }
}
