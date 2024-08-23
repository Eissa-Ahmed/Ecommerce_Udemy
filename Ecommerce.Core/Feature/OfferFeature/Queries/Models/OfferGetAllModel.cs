namespace Ecommerce.Application.Feature.OfferFeature.Queries.Models;

public sealed class OfferGetAllModel(int PageNumber, int PageSize) : IRequest<ApplicationResponse<Pagination<OfferGetAllResult>>>
{
    public int PageNumber { get; set; } = PageNumber;
    public int PageSize { get; set; } = PageSize;
}
