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

    }
}
