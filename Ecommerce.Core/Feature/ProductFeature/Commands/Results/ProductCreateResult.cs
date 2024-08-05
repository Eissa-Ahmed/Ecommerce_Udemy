namespace Ecommerce.Application.Feature.ProductFeature.Commands.Results;

public sealed class ProductCreateResult
{
    public ProductCreateResult(ICollection<ProductCreateResult_Images> images, ICollection<ProductCreateResult_ProductAttributes> productAttributes)
    {
        Images = images;
        ProductAttributes = productAttributes;
    }
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
}

public sealed class ProductCreateResult_Images
{
    public string Id { get; set; } = null!;
    public string Name { get; set; } = null!;
    public double Size { get; set; }
    public string extension => Path.GetExtension(Name);
    public string ProductId { get; set; } = null!;
}
public sealed class ProductCreateResult_ProductAttributes
{
    public string Id { get; set; } = null!;
    public string ProductId { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string AttributeId { get; set; } = null!;
    public string Value { get; set; } = null!;
}


