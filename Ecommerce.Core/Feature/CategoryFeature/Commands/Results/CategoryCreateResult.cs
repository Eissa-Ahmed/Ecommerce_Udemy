namespace Ecommerce.Application.Feature.CategoryFeature.Commands.Results;

public sealed class CategoryCreateResult
{
    public CategoryCreateResult()
    {
        subCattegories = new List<CategoryCreateResult_SubCategory>();
    }
    public string Name { get; set; } = null!;
    public IEnumerable<CategoryCreateResult_SubCategory> subCattegories { get; set; }
}

public class CategoryCreateResult_SubCategory
{
    public string? Name { get; set; } = null;
    public string? CategoryName { get; set; } = null;
}
