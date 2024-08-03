namespace Ecommerce.Application.Feature.CategoryFeature.Commands.Validations;

public sealed class CategoryDeleteValidation : AbstractValidator<CategoryDeleteModel>
{
    private readonly ICategoryValidation _categoryValidation;
    public CategoryDeleteValidation(ICategoryValidation categoryValidation)
    {
        _categoryValidation = categoryValidation;
        ApplyValidation();
    }

    private void ApplyValidation()
    {
        RuleFor(i => i.Name)
            .NotEmpty()
            .MustAsync(CategoryIsExist)
            .WithMessage("Category not found")
            .MustAsync(CategoryHasSubCategory_Or_Product)
            .WithMessage("Category has products");
    }

    private async Task<bool> CategoryHasSubCategory_Or_Product(string arg1, CancellationToken token)
    {
        return !(await _categoryValidation.CategoryHasSubCategory_Or_Product(arg1));
    }

    private async Task<bool> CategoryIsExist(string arg1, CancellationToken token)
    {
        return await _categoryValidation.CategoryIsExist(arg1);
    }
}
