namespace Ecommerce.Application.Feature.ProductFeature.Queries.Validation;

public sealed class ProductGetAllValidation : AbstractValidator<ProductGetAllModel>
{
    private readonly IProductValidation _productValidation;
    public ProductGetAllValidation(IProductValidation productValidation)
    {
        _productValidation = productValidation;
        ApplyValidation();
    }

    private void ApplyValidation()
    {
    }
}
