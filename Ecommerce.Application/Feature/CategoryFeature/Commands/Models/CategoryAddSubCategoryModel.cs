namespace Ecommerce.Application.Feature.CategoryFeature.Commands.Models;

public sealed class CategoryAddSubCategoryModel(string IdParent, string SubCategoryName) : IRequest<ApplicationResponse<CategoryAddSubCategoryResult>>
{

    public string IdParent { get; set; } = IdParent;
    public string SubCategoryName { get; set; } = SubCategoryName;
}
