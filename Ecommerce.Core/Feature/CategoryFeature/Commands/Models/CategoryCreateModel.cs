namespace Ecommerce.Application.Feature.CategoryFeature.Commands.Models;

public sealed class CategoryCreateModel : IRequest<ApplicationResponse<CategoryCreateResult>>
{
    public CategoryCreateModel()
    {
        SubCategories = new List<string>();
    }
    public string? ParentId { get; set; } = null;
    public string CategoryName { get; set; } = null!;
    public IEnumerable<string> SubCategories { get; set; }
}
