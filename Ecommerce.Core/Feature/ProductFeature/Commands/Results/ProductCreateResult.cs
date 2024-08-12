namespace Ecommerce.Application.Feature.ProductFeature.Commands.Results;

public sealed class ProductCreateResult
{
    public ProductCreateResult()
    {
        Images = new List<ProductCreateResult_Images>();
        ProductAttributes = new List<ProductCreateResult_ProductAttributes>();
        Features = new List<ProductCreateResult_Features>();
        CareInstructions = new List<ProductCreateResult_CareInstructions>();
        ProductColors = new List<ProductCreateResult_ProductColors>();
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
    public ICollection<ProductCreateResult_Features> Features { get; set; }
    public ICollection<ProductCreateResult_CareInstructions> CareInstructions { get; set; }
    public ICollection<ProductCreateResult_ProductColors> ProductColors { get; set; }
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
public sealed class ProductCreateResult_Features
{
    public string Text { get; set; } = null!;
}
public sealed class ProductCreateResult_CareInstructions
{
    public string Text { get; set; } = null!;
}

public sealed class ProductCreateResult_ProductColors
{
    public ProductCreateResult_ProductColors()
    {
        ProductSizes = new List<ProductCreateResult_ProductSizes>();

    }
    public string Color { get; set; } = null!;
    public int Count { get; set; }

    public ICollection<ProductCreateResult_ProductSizes> ProductSizes { get; set; }
}

public sealed class ProductCreateResult_ProductSizes
{
    public string Size { get; set; } = null!;
    public int Count { get; set; }
}

