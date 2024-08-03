namespace Ecommerce.Application.Feature.CategoryFeature.Commands.Results;

public sealed class CategoryUpdateResult
{
    public CategoryUpdateResult()
    {
        subCattegories = new List<CategoryUpdateResult_SubCategory>();
    }
    public string Name { get; set; } = null!;
    public IEnumerable<CategoryUpdateResult_SubCategory> subCattegories { get; set; }
}

public class CategoryUpdateResult_SubCategory
{
    public string Name { get; set; } = null!;
    public string CategoryId { get; set; } = null!;
}

