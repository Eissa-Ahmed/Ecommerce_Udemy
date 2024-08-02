namespace Ecommerce.Application.Feature.CategoryFeature.Queries.Result;

public sealed class CategoryGetAllResult
{
    public CategoryGetAllResult()
    {
        SubCategories = new List<CategoryGetAllResult_SubCategory>();
    }
    public string Name { get; set; } = null!;
    public List<CategoryGetAllResult_SubCategory> SubCategories { get; set; }
}
public sealed class CategoryGetAllResult_SubCategory
{
    public CategoryGetAllResult_SubCategory()
    {
        SubCategories = new List<CategoryGetAllResult_SubCategory>();
    }
    public string Name { get; set; } = null!;
    public List<CategoryGetAllResult_SubCategory> SubCategories { get; set; }
}
