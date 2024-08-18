namespace Ecommerce.Application.Feature.ProductFeature.Queries.Models;

public sealed class ProductGetAllModel : IRequest<ApplicationResponse<Pagination<ProductGetAllResult>>>
{
    public string? CategoryId { get; set; }
    public string? BrandId { get; set; }
    public string? Sort { get; set; }
    public int PageNumber { get; set; }
    public int PageSize { get; set; }
}
