namespace Ecommerce.Application.Feature.ProductFeature.Commands.Validations;

public sealed class ProductCreateValidation : AbstractValidator<ProductCreateModel>
{
    private readonly IProductValidation _productValidation;
    private readonly IAttributeValidation _attributeValidation;
    private readonly IBrandValidation _brandValidation;
    private readonly ICategoryValidation _categoryValidation;
    private readonly ITagValidation _tagValidation;
    private readonly IOfferValidation _offerValidation;

    public ProductCreateValidation(
        IProductValidation productValidation,
        IAttributeValidation attributeValidation,
        IBrandValidation brandValidation,
        ICategoryValidation categoryValidation,
        ITagValidation tagValidation,
        IOfferValidation offerValidation)
    {
        _productValidation = productValidation;
        _attributeValidation = attributeValidation;
        _brandValidation = brandValidation;
        _categoryValidation = categoryValidation;
        _tagValidation = tagValidation;
        _offerValidation = offerValidation;
        ApplyValidation();
    }

    private void ApplyValidation()
    {
        RuleFor(x => x.Name)
              .NotEmpty()
              .WithMessage("Name is required")
              .Length(6, 100)
              .WithMessage("Name must be between 6 and 100 characters");

        When(i => i.Description != null, () =>
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

        When(i => i.ProductVariants.Count() == 0, () =>
        {
            RuleFor(i => i.Price)
            .NotEmpty()
            .WithMessage("Price is required")
            .GreaterThan(0)
            .WithMessage("Price must be greater than 0");
        });

        When(i => i.ProductVariants.Count() != 0, () =>
        {
            RuleFor(i => i.Price)
            .Empty()
            .WithMessage("Price must be empty when add variants");
        });


        RuleFor(i => i.ProductVariants)
            .Must((model, key, cancel) => CheckCountOfProductVariants(model))
            .When(i => i.ProductVariants.Count() > 0)
            .WithMessage("Variants StockQuantity must be equal product count");

        RuleFor(i => i.DiscountId)
            .MustAsync(DiscountExistAsync)
            .When(i => i.DiscountId != null)
            .WithMessage("Discount Id does not exist");

        RuleFor(i => i.CategoryId)
             .NotEmpty()
             .WithMessage("Category Id is required")
             .MustAsync(CategoryExistAsync)
             .WithMessage("Category Id does not exist")
             .MustAsync(CategoryNotHaveSubCategoriesAsync)
             .WithMessage("The category have sub-categories");


        RuleForEach(i => i.ProductTagIds).ChildRules(tags =>
        {
            tags.RuleFor(i => i).MustAsync(TagIsExist)
            .WithMessage("Tag does not exist");
        });



        RuleForEach(i => i.ProductVariants).ChildRules(Variant =>
        {
            Variant.RuleFor(i => i.Size)
             .NotEmpty()
             .WithMessage("Size is required")
             .Must(x => x == "L" || x == "M" || x == "S" || x == "XS" || x == "XL" || x == "XXL" || x == "XXXL" || x == "XXXXL" || x == "XXXXXL" || x == "XXXXXXL")
             .WithMessage("Size must be L, M, S, XS, XL, XXL, XXXL, XXXXL, XXXXXL");

            Variant.RuleFor(i => i.Color)
            .Must(c => c.StartsWith("#") && c.Length == 7)
            .WithMessage("Color must be hex code");

            Variant.RuleFor(i => i.Price)
            .NotEmpty()
            .WithMessage("Price is required")
            .GreaterThan(0)
            .WithMessage("Price must be greater than 0");

        });



        When(i => i.BrandId != null, () =>
        {
            RuleFor(i => i.BrandId!)
             .NotEmpty()
             .WithMessage("Brand Id is required")
             .MustAsync(BrandExistAsync)
             .WithMessage("Brand Id does not exist");
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

    private async Task<bool> DiscountExistAsync(string arg1, CancellationToken token)
    {
        return await _offerValidation
            .DiscountIsExist(arg1);
    }

    private bool CheckCountOfProductVariants(ProductCreateModel model)
    {
        int countOfVariants = 0;
        foreach (var item in model.ProductVariants)
        {
            countOfVariants += item.StockQuantity;
        }
        return countOfVariants == model.StockQuantity;
    }

    private async Task<bool> TagIsExist(string arg1, CancellationToken token)
    {
        return await _tagValidation.TagIsExist(arg1);
    }

    private async Task<bool> CategoryNotHaveSubCategoriesAsync(string arg1, CancellationToken token)
    {
        return !(await _categoryValidation.CategoryHaveSubCategoriesAsync(arg1));
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

