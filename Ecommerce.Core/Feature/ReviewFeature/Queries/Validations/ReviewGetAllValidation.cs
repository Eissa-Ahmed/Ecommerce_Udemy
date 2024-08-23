namespace Ecommerce.Application.Feature.ReviewFeature.Queries.Validations;

public sealed class ReviewGetAllValidation : AbstractValidator<ReviewGetAllModel>
{
    public ReviewGetAllValidation()
    {
        ApplyValidation();
    }

    private void ApplyValidation()
    {
        RuleFor(x => x.PageNumber)
            .GreaterThan(0)
            .WithMessage("Page number must be greater than 0");
        RuleFor(x => x.PageSize)
            .GreaterThan(0)
            .WithMessage("Page size must be greater than 0");
    }
}
