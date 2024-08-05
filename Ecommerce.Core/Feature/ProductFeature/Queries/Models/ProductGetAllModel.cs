namespace Ecommerce.Application.Feature.ProductFeature.Queries.Models;

public sealed class ProductGetAllModel : IRequest<ApplicationResponse<Pagination<IEnumerable<ProductGetAllResult>>>>
{
    public int PageNumber { get; set; } = 1;
    public int PageSize { get; set; } = 10;
}
