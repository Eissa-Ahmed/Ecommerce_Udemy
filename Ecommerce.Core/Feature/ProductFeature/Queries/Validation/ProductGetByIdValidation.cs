namespace Ecommerce.Application.Feature.ProductFeature.Queries.Validation;

public sealed class ProductGetByIdValidation : AbstractValidator<ProductGetByIdModel>
{
    private readonly IProductValidation _productValidation;

    public ProductGetByIdValidation(IProductValidation productValidation)
    {
        _productValidation = productValidation;
        ApplyValidation();
    }

    private void ApplyValidation()
    {
        RuleFor(i => i.Id)
            .NotEmpty().WithMessage("Id is required")
            .MustAsync(ProductIsExist).WithMessage("Product is not exist");
    }

    private async Task<bool> ProductIsExist(string arg1, CancellationToken token)
    {
        return await _productValidation.ProductIsExist(arg1);
    }
}
