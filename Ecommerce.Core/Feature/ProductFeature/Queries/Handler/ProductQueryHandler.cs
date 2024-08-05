
namespace Ecommerce.Application.Feature.ProductFeature.Queries.Handler;

public sealed class ProductQueryHandler : ResponseHandler,
    IRequestHandler<ProductGetAllModel, ApplicationResponse<Pagination<IEnumerable<ProductGetAllResult>>>>
{
    private readonly IProductService _productService;
    private readonly IMapper _mapper;
    public ProductQueryHandler(IProductService productService, IMapper mapper)
    {
        _productService = productService;
        _mapper = mapper;
    }
    public async Task<ApplicationResponse<Pagination<IEnumerable<ProductGetAllResult>>>> Handle(ProductGetAllModel request, CancellationToken cancellationToken)
    {
        Pagination<Product> pagination = await _productService.GetAllAsync(request.PageNumber, request.PageSize);
    }
};