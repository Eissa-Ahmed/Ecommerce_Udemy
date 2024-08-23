namespace Ecommerce.Application.Feature.OfferFeature.Queries.Handler;

public sealed class OfferQueryHandler : ResponseHandler,
    IRequestHandler<OfferGetAllModel, ApplicationResponse<Pagination<OfferGetAllResult>>>
{
    private readonly IOfferService _offerService;
    private readonly IMapper _mapper;

    public OfferQueryHandler(IOfferService offerService, IMapper mapper)
    {
        _offerService = offerService;
        _mapper = mapper;
    }

    public async Task<ApplicationResponse<Pagination<OfferGetAllResult>>> Handle(OfferGetAllModel request, CancellationToken cancellationToken)
    {
        Pagination<Discount> result = await _offerService.GetAllAsync(request.PageNumber, request.PageSize);
        return Success(_mapper.Map<Pagination<OfferGetAllResult>>(result));
    }
}
