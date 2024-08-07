namespace Ecommerce.Application.Feature.ProductFeature.Queries.Handler;

public sealed class ProductQueryHandler : ResponseHandler,
    IRequestHandler<ProductGetAllModel, ApplicationResponse<Pagination<ProductGetAllResult>>>
{
    private readonly IProductService _productService;
    private readonly IMapper _mapper;
    public ProductQueryHandler(IProductService productService, IMapper mapper)
    {
        _productService = productService;
        _mapper = mapper;
    }

    public async Task<ApplicationResponse<Pagination<ProductGetAllResult>>> Handle(ProductGetAllModel request, CancellationToken cancellationToken)
    {
        List<Expression<Func<Product, bool>>> expressions = new List<Expression<Func<Product, bool>>>();
        if (request.CategoryId != null)
            expressions.Add(x => x.CategoryId == request.CategoryId);

        if (request.BrandId != null)
            expressions.Add(x => x.BrandId == request.BrandId);

        Pagination<Product> pagination = await _productService.GetAllAsync(request.PageNumber, request.PageSize, expressions);
        Pagination<ProductGetAllResult> result = _mapper.Map<Pagination<ProductGetAllResult>>(pagination);
        return Success(result);
    }

};