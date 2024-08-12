namespace Ecommerce.Application.Services.ProductContainer;

public sealed class ProductService : IProductService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IFileFactory _fileFactory;
    private readonly IProductHelper _productHelper;

    public ProductService(IUnitOfWork unitOfWork, IFileFactory fileFactory, IProductHelper productHelper)
    {
        _unitOfWork = unitOfWork;
        _fileFactory = fileFactory;
        _productHelper = productHelper;
    }

    public async Task<Product> CreateAsync(Product product)
    {

        product.MainImage = product.Images.First().Name;
        await _unitOfWork.ProductRepository.CreateAsync(product);
        Product? result = await GetByIdAsync(product.Id);
        return result!;

    }

    public async Task<Pagination<Product>> GetAllAsync(int pageNumber, int pageSize, string? sortByPrice = null, IEnumerable<Expression<Func<Product, bool>>>? criterias = null)
    {
        /*Expression<Func<Product, object>>? orderBy, orderByDesc;
        OrderByProduct(sortByPrice, out orderBy, out orderByDesc);

        ISpecification<Product> ProductSpecification = new ProductSpecification(pageNumber, pageSize, criterias.ToList(), orderBy, orderByDesc);

        IReadOnlyList<Product> products = await _unitOfWork.ProductRepository.GetAllAsync(ProductSpecification);

        int totalCount = await _unitOfWork.ProductRepository.CountAsync();
        return new Pagination<Product>(products.ToList(), pageNumber, pageSize, totalCount);*/
        throw new NotImplementedException();
    }
    public async Task<Product?> GetByIdAsync(string id)
    {
        /*List<Expression<Func<Product, bool>>> criterias = new List<Expression<Func<Product, bool>>>()
        {
            p => p.Id == id
        };
        ISpecification<Product> ProductSpecification = new ProductSpecification(criterias);
        return await _unitOfWork.ProductRepository.GetByIdAsync(ProductSpecification);*/
        throw new NotImplementedException();
    }

    private void OrderByProduct(string? sortByPrice, out Expression<Func<Product, object>>? orderBy, out Expression<Func<Product, object>>? orderByDesc)
    {
        orderBy = null;
        orderByDesc = null;
        if (sortByPrice is not null)
        {
            if (sortByPrice == "ASC")
                orderBy = i => i.Price;
            else
                orderByDesc = i => i.Price;
        }
    }
}
