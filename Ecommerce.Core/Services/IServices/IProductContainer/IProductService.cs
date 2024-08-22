namespace Ecommerce.Application.Services.IServices.IProductContainer;

public interface IProductService
{
    Task<Product> CreateAsync(Product product);
    Task<Pagination<Product>> GetAllAsync(ProductGetAllParams productGetAllParams);
    Task<Pagination<Product>> GetAllBestSellerAsync(int pageNumber, int pageSize);
    Task<Product> GetByIdAsync(string id);
    //Task<IReadOnlyList<Product>> SearchAsync(string name, string? categoryId = null, string? brandId = null);
}
