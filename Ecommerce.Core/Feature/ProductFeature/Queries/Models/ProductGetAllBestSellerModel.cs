namespace Ecommerce.Application.Feature.ProductFeature.Queries.Models;

public sealed class ProductGetAllBestSellerModel(int PageNumber, int PageSize) : IRequest<ApplicationResponse<Pagination<ProductGetAllResult>>>
{
    public int PageNumber { get; set; } = PageNumber;
    public int PageSize { get; set; } = PageSize;
}
