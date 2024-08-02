namespace Ecommerce.Application.Services.IServices.IProductContainer;

public interface IProductService
{
    Task<IReadOnlyList<Product>> GetAllProducts(int skip, int take);
    Task<Product?> GetProductById(string id);
}
