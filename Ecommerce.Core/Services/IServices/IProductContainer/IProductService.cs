namespace Ecommerce.Application.Services.IServices.IProductContainer;

public interface IProductService
{
    Task<Product> CreateAsync(Product product);
    Task<Pagination<Product>> GetAllAsync(int skip, int take, IEnumerable<Expression<Func<Product, bool>>>? criterias = null);
    Task<Product?> GetByIdAsync(string id);
}
