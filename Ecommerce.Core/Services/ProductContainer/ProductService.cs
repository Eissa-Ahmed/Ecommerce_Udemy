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

    public async Task<Product> CreateAsync(Product product, IEnumerable<IFormFile> images, IEnumerable<ProductAttributes> productAttributes)
    {
        foreach (var image in images)
        {
            product.Images.Add(new Images { Name = _fileFactory.GetFileService(image).SaveFileAsync(image), Size = image.Length });
        }
        foreach (var productAttribute in productAttributes)
        {
            productAttribute.ProductId = product.Id;
            product.ProductAttributes.Add(productAttribute);
        }

        product.MainImage = product.Images.First().Name;
        Product result = await _unitOfWork.ProductRepository.CreateAsync(product);
        return result;
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
