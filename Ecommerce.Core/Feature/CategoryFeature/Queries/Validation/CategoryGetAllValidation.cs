namespace Ecommerce.Application.Feature.CategoryFeature.Queries.Validation;

public sealed class CategoryGetAllValidation : AbstractValidator<CategoryGetAllModel>
{
    public CategoryGetAllValidation()
    {
        RuleFor(x => x.count).GreaterThan(5)
            .WithName("CountX")
            .WithMessage("Count must be greater than 5");
    }
}
