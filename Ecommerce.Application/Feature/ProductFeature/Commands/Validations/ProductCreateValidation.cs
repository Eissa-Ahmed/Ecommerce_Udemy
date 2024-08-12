



namespace Ecommerce.Application.Feature.ProductFeature.Commands.Validations;

public sealed class ProductCreateValidation : AbstractValidator<ProductCreateModel>
{
    private readonly IProductValidation _productValidation;
    private readonly IAttributeValidation _attributeValidation;
    private readonly IBrandValidation _brandValidation;
    private readonly ICategoryValidation _categoryValidation;

    public ProductCreateValidation(IProductValidation productValidation, IAttributeValidation attributeValidation, IBrandValidation brandValidation, ICategoryValidation categoryValidation)
    {
        _productValidation = productValidation;
        _attributeValidation = attributeValidation;
        _brandValidation = brandValidation;
        ApplyValidation();
        _categoryValidation = categoryValidation;
    }

    private void ApplyValidation()
    {
        RuleFor(x => x.Name)
              .NotEmpty()
              .WithMessage("Name is required")
              .Length(6, 100)
              .WithMessage("Name must be between 6 and 100 characters");

        When(i => !i.Description.IsNullOrEmpty(), () =>
        {
            RuleFor(x => x.Description)
              .NotEmpty()
              .WithMessage("Description is required")
              .Length(25, 500)
              .WithMessage("Description must be between 25 and 500 characters");
        });

        RuleFor(i => i.StockQuantity)
              .GreaterThan(0)
              .WithMessage("Stock Quantity must be greater than 0");

        RuleFor(i => i.Price)
              .GreaterThan(0)
              .WithMessage("Price must be greater than 0");

        RuleFor(i => i.Discount)
             .GreaterThanOrEqualTo(0)
             .WithMessage("Discount must be greater than or equal to 0")
             .LessThanOrEqualTo(100)
             .WithMessage("Discount must be less than or equal to 100");


        RuleFor(i => i.CategoryId)
             .NotEmpty()
             .WithMessage("Category Id is required")
             .MustAsync(CategoryExistAsync)
             .WithMessage("Category Id does not exist")
             .MustAsync(CategoryNotHaveSubCategoriesAsync)
             .WithMessage("The category have sub-categories");

        When(i => !i.BrandId.IsNullOrEmpty(), () =>
        {
            RuleFor(i => i.BrandId!)
             .NotEmpty()
             .WithMessage("Brand Id is required")
             .MustAsync(BrandExistAsync)
             .WithMessage("Brand Id does not exist");
        });

        RuleFor(i => i.Images)
             .NotEmpty()
             .WithMessage("Image is required")
             .Must(images => images != null && images.Count() > 1)
             .WithMessage("The number of images must be greater than 1.");

        When(i => i.ProductColors.Count() > 0, () =>
        {
            RuleFor(i => i.ProductColors)
            .Must((model, item, cancel) => CheckCountProductColorEqualCountProduct(model))
            .WithMessage("The number of product colors must be equal to the number of colors");


            RuleForEach(i => i.ProductColors).ChildRules(productColor =>
            {
                productColor.RuleFor(i => i.Color)
                .NotEmpty()
                .WithMessage("Color is required");

                productColor.When(i => i.ProductSizes.Count() > 0, () =>
                {
                    productColor.RuleFor(i => i.ProductSizes)
                        .Must((model, item, cancel) => CheckCountProductSizeEqualCountProduct(model))
                        .WithMessage("The number of product sizes must be equal to the number of sizes");
                });
            });
        });




        When(i => i.Features.Count() > 0, () =>
        {
            RuleForEach(i => i.Features).ChildRules(features =>
            {
                features.RuleFor(i => i.Text)
                .NotEmpty()
                .WithMessage("Value is required")
                .MaximumLength(100)
                .WithMessage("Value must be less than 100 characters");
            });

        });

        When(i => i.CareInstructions.Count() > 0, () =>
        {
            RuleForEach(i => i.CareInstructions).ChildRules(careInstruction =>
            {
                careInstruction.RuleFor(i => i.Text)
                .NotEmpty()
                .WithMessage("Value is required")
                .MaximumLength(150)
                .WithMessage("Value must be less than 150 characters");
            });

        });


    }

    private async Task<bool> CategoryNotHaveSubCategoriesAsync(string arg1, CancellationToken token)
    {
        return !(await _categoryValidation.CategoryHaveSubCategoriesAsync(arg1));
    }

    private bool CheckCountProductColorEqualCountProduct(ProductCreateModel model)
    {
        int count = model.ProductColors.Sum(x => x.Count);
        return count == model.StockQuantity;
    }

    private bool CheckCountProductSizeEqualCountProduct(ProductCreateModel_ProductColors model)
    {
        int count = model.ProductSizes.Sum(x => x.Count);
        return count == model.Count;
    }


    private async Task<bool> BrandExistAsync(string arg1, CancellationToken token)
    {
        return await _brandValidation.BrandIsExist(arg1);
    }

    private async Task<bool> CategoryExistAsync(string arg1, CancellationToken token)
    {
        return await _categoryValidation.CategoryIsExist_ById(arg1);
    }
}

public sealed class ProductCreateValidation_ProductAttribute : AbstractValidator<ProductCreateModel_ProductAttributes>
{
    private readonly IAttributeValidation _attributeValidation;

    public ProductCreateValidation_ProductAttribute(IAttributeValidation attributeValidation)
    {
        _attributeValidation = attributeValidation;
        ApplyValidation();
    }

    private void ApplyValidation()
    {
        RuleFor(i => i.AttributeId)
             .MustAsync(AttributeExistAsync)
             .WithMessage("Attribute Id does not exist");
    }

    private async Task<bool> AttributeExistAsync(string arg1, CancellationToken token)
    {
        return await _attributeValidation.AttributeIsExist(arg1);
    }
}