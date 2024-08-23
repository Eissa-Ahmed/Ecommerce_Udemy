namespace Ecommerce.Application.Services.ReviewContainer;

public sealed class ReviewService : IReviewService
{
    private readonly IUnitOfWork _unitOfWork;

    public ReviewService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<Pagination<Review>> GetAllAsync(int pageNumber, int pageSize)
    {
        ReviewGetAllSpecification reviewGetAllSpecification = new ReviewGetAllSpecification(pageNumber, pageSize);
        IReadOnlyList<Review> reviews = await _unitOfWork.ReviewRepository.GetAllAsync(reviewGetAllSpecification);
        return new Pagination<Review>(reviews.ToList(), pageNumber, pageSize, await _unitOfWork.ReviewRepository.CountAsync());
    }
}
