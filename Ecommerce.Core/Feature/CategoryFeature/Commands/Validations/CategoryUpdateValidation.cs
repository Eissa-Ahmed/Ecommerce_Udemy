namespace Ecommerce.Application.Feature.CategoryFeature.Commands.Validations;

public sealed class CategoryUpdateValidation : AbstractValidator<CategoryUpdateModel>
{
    private readonly ICategoryValidation _categoryValidation;
    public CategoryUpdateValidation(ICategoryValidation categoryValidation)
    {
        _categoryValidation = categoryValidation;
        ApplyValidation();
    }

    private void ApplyValidation()
    {
        RuleFor(x => x.CategoryName)
            .NotEmpty()
            .WithMessage("Category name is required")
            .MustAsync(CategoryIsExist)
            .WithMessage("Category not found");

        RuleFor(x => x.NewCategoryName)
            .NotEmpty()
            .WithMessage("New category name is required")
            .MustAsync(async (model, key, cancel) => !await CategoryIsExist(key, cancel))
            .WithMessage("Category already exist");

    }

    private async Task<bool> CategoryIsExist(string arg1, CancellationToken token)
    {
        return await _categoryValidation.CategoryIsExist(arg1);
    }
}
