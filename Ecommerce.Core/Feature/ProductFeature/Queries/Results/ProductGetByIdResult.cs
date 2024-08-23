namespace Ecommerce.Application.Feature.ProductFeature.Queries.Results;

public sealed class ProductGetByIdResult
{
    public ProductGetByIdResult()
    {
        Images = new List<ProductGetByIdResult_Images>();
        ProductAttributes = new List<ProductGetByIdResult_ProductAttributes>();
        Reviews = new List<ProductGetByIdResult_Review>();
        Features = new List<ProductGetByIdResult_Features>();
        CareInstructions = new List<ProductGetByIdResult_CareInstructions>();
        ProductVariant = new List<ProductGetByIdResult_ProductVariant>();
    }
    public string Id { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string MainImage { get; set; } = null!;
    public int StockQuantity { get; set; }
    public decimal Price { get; set; }
    public int Discount { get; set; }
    public bool IsFreeShipping { get; set; }
    public DateTime CreatedDate { get; set; }
    public string CategoryId { get; set; } = null!;
    public string? BrandId { get; set; } = null;
    public string? BrandName { get; set; } = null;
    public double TotalRating { get; set; }
    public ICollection<ProductGetByIdResult_Images> Images { get; set; }
    public ICollection<ProductGetByIdResult_ProductAttributes> ProductAttributes { get; set; }
    public ICollection<ProductGetByIdResult_Review> Reviews { get; set; }
    public ICollection<ProductGetByIdResult_Features> Features { get; set; }
    public ICollection<ProductGetByIdResult_CareInstructions> CareInstructions { get; set; }
    public ICollection<ProductGetByIdResult_ProductVariant> ProductVariant { get; set; }

}

public sealed class ProductGetByIdResult_Images
{
    public string Id { get; set; } = null!;
    public string Name { get; set; } = null!;
    public double Size { get; set; }
    public string extension => Path.GetExtension(Name);
    public string ProductId { get; set; } = null!;
}
public sealed class ProductGetByIdResult_ProductAttributes
{
    public string Id { get; set; } = null!;
    public string ProductId { get; set; } = null!;
    public string AttributeId { get; set; } = null!;
    public string Value { get; set; } = null!;
}

public sealed class ProductGetByIdResult_Review
{
    public string Id { get; set; } = null!;
    public string ProductId { get; set; } = null!;
    public string UserId { get; set; } = null!;
    public string UserName { get; set; } = null!;
    public string Comment { get; set; } = null!;
    public DateTime CreatedDate { get; set; }
}

public sealed class ProductGetByIdResult_Features
{
    public string Id { get; set; } = null!;
    public string Text { get; set; } = null!;
    public string ProductId { get; set; } = null!;
}

public sealed class ProductGetByIdResult_CareInstructions
{
    public string Id { get; set; } = null!;
    public string Text { get; set; } = null!;
    public string ProductId { get; set; } = null!;
}

public sealed class ProductGetByIdResult_ProductVariant
{
    public string Id { get; set; } = null!;
    public string? Color { get; set; } = null;
    public string Size { get; set; } = null!;
    public string? Material { get; set; } = null;
    public decimal Price { get; set; }
    public int StockQuantity { get; set; }
    public string SKU { get; set; } = null!;
}