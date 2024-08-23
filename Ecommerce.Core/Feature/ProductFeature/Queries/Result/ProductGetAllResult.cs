namespace Ecommerce.Application.Feature.ProductFeature.Queries.Result;

public sealed class ProductGetAllResult
{
    public ProductGetAllResult()
    {
        ProductVariant = new List<ProductGetAllResult_ProductVariant>();
    }
    public string Id { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string MainImage { get; set; } = null!;
    public int StockQuantity { get; set; }
    public bool IsFreeShipping { get; set; }
    public decimal Price { get; set; }
    public DateTime CreatedDate { get; set; }
    public string CategoryId { get; set; } = null!;
    public string? BrandId { get; set; } = null;
    public double Rating { get; set; }
    public decimal DiscountPercentage { get; set; }
    public ICollection<ProductGetAllResult_ProductVariant> ProductVariant { get; set; }

}
public class ProductGetAllResult_ProductVariant
{
    public string Id { get; set; } = null!;
    public string ProductId { get; set; } = null!;
    public string? Color { get; set; } = null;
    public string Size { get; set; } = null!;
    public string? Material { get; set; } = null;
    public decimal Price { get; set; }
    public int StockQuantity { get; set; }
    public string SKU => Color + "-" + Size + "-" + Material;
}





