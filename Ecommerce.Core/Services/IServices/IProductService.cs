namespace Ecommerce.Application.Services.IServices;

public interface IProductService
{
    Task<IReadOnlyList<Product>> GetAllProducts(int skip, int take);
    Task<Product?> GetProductById(string id);
}
