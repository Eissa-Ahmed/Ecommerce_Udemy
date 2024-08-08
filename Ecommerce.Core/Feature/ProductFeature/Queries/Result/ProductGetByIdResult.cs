namespace Ecommerce.Application.Feature.ProductFeature.Queries.Result;

public sealed class ProductGetByIdResult
{
    public string Id { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string MainImage { get; set; } = null!;
    public int StockQuantity { get; set; }
    public decimal Price { get; set; }
    public int Discount { get; set; }
    public bool FreeShipping { get; set; }
    public DateTime CreatedDate { get; set; }
    public string CategoryId { get; set; } = null!;
    public string? BrandId { get; set; } = null;
    public string? BrandName { get; set; } = null;
    public ICollection<ProductCreateResult_Images> Images { get; set; }
    public ICollection<ProductCreateResult_ProductAttributes> ProductAttributes { get; set; }
    public ICollection<ProductCreateResult_Features> Features { get; set; }
    public ICollection<ProductCreateResult_CareInstructions> CareInstructions { get; set; }
    public ICollection<ProductCreateResult_ProductColors> ProductColors { get; set; }
}
