namespace Ecommerce.Application.Feature.CategoryFeature.Commands.Validations;

public sealed class CategoryUpdateValidation : AbstractValidator<CategoryUpdateNameModel>
{
    private readonly ICategoryValidation _categoryValidation;
    public CategoryUpdateValidation(ICategoryValidation categoryValidation)
    {
        _categoryValidation = categoryValidation;
        ApplyValidation();
    }

    private void ApplyValidation()
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage("Category id is required")
            .MustAsync(CategoryIsExist_ById)
            .WithMessage("Category not found");

        RuleFor(x => x.Name)
            .NotEmpty()
            .WithMessage("New category name is required")
            .MustAsync(CategoryIsExist_ByName)
            .WithMessage("Category already exist");

    }

    private async Task<bool> CategoryIsExist_ById(string arg1, CancellationToken token)
    {
        return await _categoryValidation.CategoryIsExist_ById(arg1);
    }
    private async Task<bool> CategoryIsExist_ByName(string arg1, CancellationToken token)
    {
        return !(await _categoryValidation.CategoryIsExist_ByName(arg1));
    }
}
