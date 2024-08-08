namespace Ecommerce.Application.Feature.ProductFeature.Queries.Models;

public sealed class ProductGetAllModel : IRequest<ApplicationResponse<Pagination<ProductGetAllResult>>>
{
    public ProductGetAllModel(int pageNumber, int pageSize, string? categoryId, string? brandId, string? sortByPrice, string? search)
    {
        PageNumber = pageNumber;
        PageSize = pageSize;
        CategoryId = categoryId;
        BrandId = brandId;
        SortByPrice = sortByPrice;
        Search = search;
    }

    public int PageNumber { get; set; }
    public int PageSize { get; set; }
    public string? CategoryId { get; set; } = null;
    public string? BrandId { get; set; } = null;
    public string? SortByPrice { get; set; } = null;
    public string? Search { get; set; } = null;
}
