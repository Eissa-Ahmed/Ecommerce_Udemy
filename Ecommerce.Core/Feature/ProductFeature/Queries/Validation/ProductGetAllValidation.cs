
namespace Ecommerce.Application.Feature.ProductFeature.Queries.Validation;

public sealed class ProductGetAllValidation : AbstractValidator<ProductGetAllModel>
{
    private readonly IProductValidation _productValidation;
    private readonly ICategoryValidation _categoryValidation;
    private readonly IBrandValidation _brandValidation;
    public ProductGetAllValidation(IProductValidation productValidation, ICategoryValidation categoryValidation, IBrandValidation brandValidation)
    {
        _productValidation = productValidation;
        _categoryValidation = categoryValidation;
        _brandValidation = brandValidation;
        ApplyValidation();
    }

    private void ApplyValidation()
    {
        RuleFor(x => x.PageNumber).GreaterThan(0);
        RuleFor(x => x.PageSize).GreaterThan(0);
        When(i => i.Sort != null, () =>
        {
            RuleFor(x => x.Sort).Must(x => x == "ASC" || x == "DESC" || x == "NAME")
            .WithMessage("SortByPrice must be ASC or DESC or NAME");
        });
        When(i => !i.CategoryId.IsNullOrEmpty(), () =>
        {
            RuleFor(x => x.CategoryId!)
            .MustAsync(CategoryIsExist)
            .WithMessage("Category is not exist");
        });
        When(i => !i.BrandId.IsNullOrEmpty(), () =>
        {
            RuleFor(x => x.BrandId!)
            .MustAsync(BrandIsExist)
            .WithMessage("Brand is not exist");
        });

    }

    private async Task<bool> BrandIsExist(string arg1, CancellationToken token)
    {
        return await _brandValidation.BrandIsExist(arg1);
    }

    private async Task<bool> CategoryIsExist(string arg1, CancellationToken token)
    {
        return await _categoryValidation.CategoryIsExist_ById(arg1);
    }
}
