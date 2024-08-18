namespace Ecommerce.Domain.Params;

public sealed class ProductGetAllParams
{
    public string? CategoryId { get; set; }
    public string? BrandId { get; set; }
    public ProductSort? Sort { get; set; }
    public int PageNumber { get; set; }
    public int PageSize { get; set; }
}
