namespace Ecommerce.Application.Feature.CategoryFeature.Commands.Models;

public sealed class CategoryUpdateModel : IRequest<ApplicationResponse<CategoryUpdateResult>>
{
    public string CategoryName { get; set; } = null!;
    public string NewCategoryName { get; set; } = null!;

}
