namespace Ecommerce.Application.Feature.ProductFeature.Commands.Handler;

public sealed class ProductCommandHandler : ResponseHandler,
        IRequestHandler<ProductCreateModel, ApplicationResponse<ProductCreateResult>>
{
    private readonly IProductService _productService;
    private readonly IMapper _mapper;

    public ProductCommandHandler(IProductService productService, IMapper mapper)
    {
        _productService = productService;
        _mapper = mapper;
    }

    public async Task<ApplicationResponse<ProductCreateResult>> Handle(ProductCreateModel request, CancellationToken cancellationToken)
    {
        Product product = _mapper.Map<Product>(request);
        /*IEnumerable<ProductAttributes> productAttributes = _mapper.Map<IEnumerable<ProductAttributes>>(request.ProductAttributes);
        product.ProductAttributes = productAttributes.ToList();*/
        Product results = await _productService.CreateAsync(product);
        return Created(_mapper.Map<ProductCreateResult>(results));
    }
}
