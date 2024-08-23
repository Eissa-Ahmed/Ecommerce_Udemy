namespace Ecommerce.Application.Feature.ProductFeature.Queries.Validations;

public sealed class ProductGetAllBestSellerValidation : AbstractValidator<ProductGetAllBestSellerModel>
{
    public ProductGetAllBestSellerValidation()
    {
        ApplyValidation();
    }

    private void ApplyValidation()
    {
        RuleFor(i => i.PageNumber)
            .GreaterThan(0)
            .WithMessage("PageNumber at least greater than 0");
        RuleFor(i => i.PageSize)
            .GreaterThan(0)
            .WithMessage("PageSize at least greater than 0");
    }
}
