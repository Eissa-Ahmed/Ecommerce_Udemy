namespace Ecommerce.Application.Feature.ProductFeature.Queries.Models;

public sealed class ProductGetAllModel : IRequest<ApplicationResponse<Pagination<ProductGetAllResult>>>
{
    public int PageNumber { get; set; }
    public int PageSize { get; set; }
    public string? CategoryId { get; set; } = null;
    public string? BrandId { get; set; } = null;
}
