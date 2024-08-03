namespace Ecommerce.Application.Feature.CategoryFeature.Queries.Validation;

public sealed class CategoryGetByIdValiation : AbstractValidator<CategoryGetByIdModel>
{
    private readonly ICategoryValidation _categoryValidation;

    public CategoryGetByIdValiation(ICategoryValidation categoryValidation)
    {
        _categoryValidation = categoryValidation;
        ApplyValidation();
    }

    private void ApplyValidation()
    {
        RuleFor(i => i.Id)
            .NotEmpty()
            .WithMessage("Id is required")
            .MustAsync(CategoryIsExist)
            .WithMessage("Category is not exist");
    }

    private async Task<bool> CategoryIsExist(string arg1, CancellationToken token)
    {
        return await _categoryValidation.CategoryIsExist(arg1);
    }
}
