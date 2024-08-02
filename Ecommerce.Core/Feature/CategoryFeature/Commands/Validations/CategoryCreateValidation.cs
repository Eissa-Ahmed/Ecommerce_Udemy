namespace Ecommerce.Application.Feature.CategoryFeature.Commands.Validations;

public sealed class CategoryCreateValidation : AbstractValidator<CategoryCreateModel>
{
    private readonly ICategoryValidation _categoryValidation;
    private readonly ISubCategoryValidation _subCategoryValidation;
    public CategoryCreateValidation(ICategoryValidation categoryValidation, ISubCategoryValidation subCategoryValidation)
    {
        _categoryValidation = categoryValidation;
        _subCategoryValidation = subCategoryValidation;
        ApplyValidation();
    }

    private void ApplyValidation()
    {
        RuleFor(x => x.CategoryName)
            .NotEmpty()
            .WithMessage("Category name is required")
            .MustAsync(CategoryIsExist)
            .WithMessage("Category already exist");

        When(i => i.SubCategories.Any(), () =>
        {
            RuleForEach(i => i.SubCategories)
            .SetValidator(new CategoryCreateValidation_SubCategory(_subCategoryValidation));
        });

    }

    private async Task<bool> CategoryIsExist(string arg1, CancellationToken token)
    {
        return !(await _categoryValidation.CategoryIsExist(arg1));
    }
}

public class CategoryCreateValidation_SubCategory : AbstractValidator<string>
{
    private readonly ISubCategoryValidation _subCategoryValidation;

    public CategoryCreateValidation_SubCategory(ISubCategoryValidation subCategoryValidation)
    {
        _subCategoryValidation = subCategoryValidation;
        ApplyValidation();
    }

    private void ApplyValidation()
    {
        RuleFor(x => x)
           .MustAsync(SubCategoryIsExist)
           .WithMessage("SubCategory {PropertyValue} already exist");
    }

    private async Task<bool> SubCategoryIsExist(string arg1, CancellationToken token)
    {
        return !(await _subCategoryValidation.SubCategoryIsExist(arg1));
    }
}
