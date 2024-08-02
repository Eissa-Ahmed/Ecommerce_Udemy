namespace Ecommerce.Application.Feature.CategoryFeature.Queries.Handler;

public sealed class CategoryQueryHandler : ResponseHandler,
    IRequestHandler<CategoryGetAllModel, ApplicationResponse<IReadOnlyList<CategoryGetAllResult>>>
{
    private readonly ICategoryServices _categoryServices;
    private readonly IMapper _mapper;

    public CategoryQueryHandler(ICategoryServices categoryServices, IMapper mapper)
    {
        _categoryServices = categoryServices;
        _mapper = mapper;
    }

    public async Task<ApplicationResponse<IReadOnlyList<CategoryGetAllResult>>> Handle(CategoryGetAllModel request, CancellationToken cancellationToken)
    {
        return Success(_mapper.Map<IReadOnlyList<CategoryGetAllResult>>(await _categoryServices.GetAllAsync()));
    }
}
