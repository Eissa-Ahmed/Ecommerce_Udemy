namespace Ecommerce.Application.Feature.ReviewFeature.Queries.Handler;

public sealed class ReviewQueryHandler : ResponseHandler,
    IRequestHandler<ReviewGetAllModel, ApplicationResponse<Pagination<ReviewGetAllResult>>>
{
    private readonly IReviewService _reviewService;
    private readonly IMapper _mapper;

    public ReviewQueryHandler(IReviewService reviewService, IMapper mapper)
    {
        _reviewService = reviewService;
        _mapper = mapper;
    }

    public async Task<ApplicationResponse<Pagination<ReviewGetAllResult>>> Handle(ReviewGetAllModel request, CancellationToken cancellationToken)
    {
        Pagination<Review> reviews = await _reviewService.GetAllAsync(request.PageNumber, request.PageSize);
        return Success(_mapper.Map<Pagination<ReviewGetAllResult>>(reviews));
    }
}
