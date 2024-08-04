namespace Ecommerce.Application.Feature.CategoryFeature.Commands.Results;

public sealed class CategoryAddSubCategoryResult
{
    public CategoryAddSubCategoryResult()
    {
        subCattegories = new List<CategoryAddSubCategoryResult_SubCategory>();
    }
    public string Id { get; set; } = null!;
    public string Name { get; set; } = null!;
    public IEnumerable<CategoryAddSubCategoryResult_SubCategory> subCattegories { get; set; }
}

public class CategoryAddSubCategoryResult_SubCategory
{
    public string Id { get; set; } = null!;
    public string? Name { get; set; } = null;
    public string? CategoryId { get; set; } = null;
}

