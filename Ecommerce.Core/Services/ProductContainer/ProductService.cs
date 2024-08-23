namespace Ecommerce.Application.Services.ProductContainer;

public sealed class ProductService : IProductService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IFileFactory _fileFactory;
    private readonly NotificationFactory _notificationFactory;

    public ProductService(IUnitOfWork unitOfWork, IFileFactory fileFactory, NotificationFactory notificationFactory)
    {
        _unitOfWork = unitOfWork;
        _fileFactory = fileFactory;
        _notificationFactory = notificationFactory;
    }

    public async Task<Product> CreateAsync(Product product)
    {
        product.MainImage = product.Images.First().Name;

        if (product.Price == 0 || product.Price == null)
            product.Price = product.ProductVariant.Min(i => i.Price);

        await _unitOfWork.ProductRepository.CreateAsync(product);
        return await GetByIdAsync(product.Id);
    }

    public async Task<Pagination<Product>> GetAllAsync(ProductGetAllParams productGetAllParams)
    {


        ISpecification<Product, Product> ProductSpecification = new ProductGetAllSpecification(productGetAllParams);

        IReadOnlyList<Product> products = await _unitOfWork.ProductRepository.GetAllAsync(ProductSpecification);

        int totalCount = await _unitOfWork.ProductRepository.CountAsync();
        return new Pagination<Product>(products.ToList(), productGetAllParams.PageNumber, productGetAllParams.PageSize, totalCount);

    }

    public async Task<Pagination<Product>> GetAllBestSellerAsync(int pageNumber, int pageSize)
    {
        ProductGetAllBestSellerSpecification productGetAllBestSellerSpecification = new ProductGetAllBestSellerSpecification(pageNumber, pageSize);
        IReadOnlyList<Product> products = await _unitOfWork.ProductRepository.GetAllAsync(productGetAllBestSellerSpecification);

        int totalCount = await _unitOfWork.ProductRepository.CountAsync();
        return new Pagination<Product>(products.ToList(), pageNumber, pageSize, totalCount);
    }

    public async Task<Product> GetByIdAsync(string id)
    {

        ISpecification<Product, Product> ProductSpecification = new ProductGetByIdSpecification(id);
        return await _unitOfWork.ProductRepository.GetByIdAsync(ProductSpecification);
    }

}
