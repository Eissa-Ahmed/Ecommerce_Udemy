namespace Ecommerce.Application.Services.IServices.IReviewContainer;

public interface IReviewService
{
    Task<Pagination<Review>> GetAllAsync(int pageNumber, int pageSize);
}
