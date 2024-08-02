namespace Ecommerce.Application.Feature.CategoryFeature.Commands.Models;

public sealed class CategoryUpdateModel : IRequest<ApplicationResponse<CategoryUpdateResult>>
{
    public CategoryUpdateModel()
    {
        SubCategories = new List<string>();
    }
    public string CategoryName { get; set; } = null!;
    public IEnumerable<string> SubCategories { get; set; }

}
