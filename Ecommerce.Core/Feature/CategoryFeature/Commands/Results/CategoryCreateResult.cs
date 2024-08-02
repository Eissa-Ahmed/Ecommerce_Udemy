namespace Ecommerce.Application.Feature.CategoryFeature.Commands.Results;

public sealed class CategoryCreateResult
{
    public CategoryCreateResult()
    {
        subCattegories = new List<CategoryCreateResult_SubCattegory>();
    }
    public string Name { get; set; } = null!;
    public IEnumerable<CategoryCreateResult_SubCattegory> subCattegories { get; set; }
}

public class CategoryCreateResult_SubCattegory
{
    public string? Name { get; set; } = null;
    public string? CategoryName { get; set; } = null;
}
