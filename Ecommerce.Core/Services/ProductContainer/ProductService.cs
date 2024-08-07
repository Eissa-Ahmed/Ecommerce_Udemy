namespace Ecommerce.Application.Services.ProductContainer;

public sealed class ProductService : IProductService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IFileFactory _fileFactory;

    public ProductService(IUnitOfWork unitOfWork, IFileFactory fileFactory)
    {
        _unitOfWork = unitOfWork;
        _fileFactory = fileFactory;
    }

    public async Task<Product> CreateAsync(Product product)
    {

        product.MainImage = product.Images.First().Name;
        await _unitOfWork.ProductRepository.CreateAsync(product);
        Product? result = await GetByIdAsync(product.Id);
        return result!;

    }

    public async Task<Pagination<Product>> GetAllAsync(int pageNumber, int pageSize, IEnumerable<Expression<Func<Product, bool>>>? criterias = null)
    {
        ISpecification<Product> ProductSpecification = criterias is null ?
            new ProductSpecification(pageNumber, pageSize) :
            new ProductSpecification(pageNumber, pageSize, criterias.ToList());

        IReadOnlyList<Product> products = await _unitOfWork.ProductRepository.GetAllAsync(ProductSpecification);
        int totalCount = await _unitOfWork.ProductRepository.CountAsync();
        return new Pagination<Product>(products.ToList(), pageNumber, pageSize, totalCount);
    }

    public async Task<Product?> GetByIdAsync(string id)
    {
        List<Expression<Func<Product, bool>>> criterias = new List<Expression<Func<Product, bool>>>()
        {
            p => p.Id == id
        };
        ISpecification<Product> ProductSpecification = new ProductSpecification(criterias);
        return await _unitOfWork.ProductRepository.GetByIdAsync(ProductSpecification);
    }
}
