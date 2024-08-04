
namespace Ecommerce.Application.Feature.CategoryFeature.Commands.Validations;

public sealed class CategoryAddSubCategoryValidation : AbstractValidator<CategoryAddSubCategoryModel>
{
    private readonly ICategoryValidation _categoryValidation;
    public CategoryAddSubCategoryValidation(ICategoryValidation categoryValidation)
    {
        _categoryValidation = categoryValidation;
        ApplyValidation();
    }

    private void ApplyValidation()
    {
        RuleFor(x => x.IdParent)
            .NotEmpty()
            .WithMessage("Category name is required")
            .MustAsync(CategoryIsExist_ById)
            .WithMessage("Category not exist");

        RuleFor(x => x.SubCategoryName)
            .NotEmpty()
            .WithMessage("Category name is required")
            .MustAsync(CategoryIsExist)
            .WithMessage("Category already exist");



    }

    private async Task<bool> CategoryIsExist_ById(string arg1, CancellationToken token)
    {
        return await _categoryValidation.CategoryIsExist_ById(arg1);
    }

    private async Task<bool> CategoryIsExist(string arg1, CancellationToken token)
    {
        return !(await _categoryValidation.CategoryIsExist_ByName(arg1));
    }
}
