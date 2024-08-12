namespace Ecommerce.Application.Feature.CategoryFeature.Commands.Validations;

public sealed class CategoryCreateValidation : AbstractValidator<CategoryCreateModel>
{
    private readonly ICategoryValidation _categoryValidation;
    public CategoryCreateValidation(ICategoryValidation categoryValidation)
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
            .WithMessage("Category already exist");

        When(i => i.SubCategories.Count() > 0, () =>
        {
            RuleForEach(i => i.SubCategories)
            .SetValidator(new CategoryCreateValidation_SubCategory(_categoryValidation));
        });

    }

    private async Task<bool> CategoryIsExist(string arg1, CancellationToken token)
    {
        return !(await _categoryValidation.CategoryIsExist_ByName(arg1));
    }
}

public class CategoryCreateValidation_SubCategory : AbstractValidator<string>
{
    private readonly ICategoryValidation _categoryValidation;

    public CategoryCreateValidation_SubCategory(ICategoryValidation categoryValidation)
    {
        ApplyValidation();
        _categoryValidation = categoryValidation;
    }

    private void ApplyValidation()
    {
        RuleFor(x => x)
           .MustAsync(SubCategoryIsExist)
           .WithMessage("SubCategory {PropertyValue} already exist");
    }

    private async Task<bool> SubCategoryIsExist(string arg1, CancellationToken token)
    {
        return !(await _categoryValidation.CategoryIsExist_ByName(arg1));
    }
}
