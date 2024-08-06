namespace Ecommerce.Application.Feature.ProductFeature.Commands.Models;

public sealed class ProductCreateModel : IRequest<ApplicationResponse<ProductCreateResult>>
{
    public ProductCreateModel()
    {
        Images = new List<IFormFile>();
        ProductAttributes = new List<ProductCreateModel_ProductAttributes>();
        Features = new List<ProductCreateModel_Features>();
        CareInstructions = new List<ProductCreateModel_CareInstructions>();
    }
    public string Name { get; set; } = null!;
    public string? Description { get; set; } = null;
    public int StockQuantity { get; set; }
    public decimal Price { get; set; }
    public int Discount { get; set; }
    public bool FreeShipping { get; set; }
    public string CategoryId { get; set; } = null!;
    public string? BrandId { get; set; } = null;
    public IEnumerable<IFormFile> Images { get; set; }
    public IEnumerable<ProductCreateModel_ProductAttributes> ProductAttributes { get; set; }
    public IEnumerable<ProductCreateModel_Features> Features { get; set; }
    public IEnumerable<ProductCreateModel_CareInstructions> CareInstructions { get; set; }
}
public sealed class ProductCreateModel_ProductAttributes
{
    public string AttributeId { get; set; } = null!;
    public string Value { get; set; } = null!;
}
public sealed class ProductCreateModel_Features
{
    public string Text { get; set; } = null!;
}
public sealed class ProductCreateModel_CareInstructions
{
    public string Text { get; set; } = null!;
}
