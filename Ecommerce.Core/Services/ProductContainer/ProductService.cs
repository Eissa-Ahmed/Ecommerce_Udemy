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
        try
        {
            product.MainImage = product.Images.First().Name;
            await _unitOfWork.ProductRepository.CreateAsync(product);
            Product? result = await GetByIdAsync(product.Id);
            return result!;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public Task<IReadOnlyList<Product>> GetAllAsync(int skip, int take, IEnumerable<Expression<Func<Product, bool>>> criterias)
    {
        ISpecification<Product> ProductSpecification = new ProductSpecification(skip, take, criterias.ToList());
        return _unitOfWork.ProductRepository.GetAllAsync(ProductSpecification);
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
