namespace Ecommerce.Application.Feature.ReviewFeature.Queries.Models
{
    public sealed class ReviewGetAllModel(int PageNumber, int PageSize) : IRequest<ApplicationResponse<Pagination<ReviewGetAllResult>>>
    {
        public int PageNumber { get; set; } = PageNumber;
        public int PageSize { get; set; } = PageSize;
    }
}
