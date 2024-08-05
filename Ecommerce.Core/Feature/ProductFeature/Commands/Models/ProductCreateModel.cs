namespace Ecommerce.Application.Feature.ProductFeature.Commands.Models;

public sealed class ProductCreateModel : IRequest<ApplicationResponse<ProductCreateResult>>
{
    public ProductCreateModel()
    {
        Images = new List<IFormFile>();
        ProductAttributes = new List<ProductCreateModel_ProductAttributes>();
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
}
public sealed class ProductCreateModel_ProductAttributes
{
    public string AttributeId { get; set; } = null!;
    public string Value { get; set; } = null!;
}
