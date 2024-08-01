namespace Ecommerce.Application.Services;

public sealed class ProductService : IProductService
{
    private readonly IUnitOfWork _unitOfWork;

    public ProductService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public Task<IReadOnlyList<Product>> GetAllProducts(int skip, int take)
    {
        ISpecification<Product> ProductSpecification = new ProductSpecification(skip, take);
        return _unitOfWork.ProductRepository.GetAllAsync(ProductSpecification);
    }

    public async Task<Product?> GetProductById(string id)
    {
        ISpecification<Product> ProductSpecification = new ProductSpecification(id);
        return await _unitOfWork.ProductRepository.GetByIdAsync(ProductSpecification);
    }
}
