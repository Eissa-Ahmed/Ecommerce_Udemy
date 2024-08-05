namespace Ecommerce.Application.Services.IServices.IProductContainer;

public interface IProductService
{
    Task<Product> CreateAsync(Product product, IEnumerable<IFormFile> images, IEnumerable<ProductAttributes> productAttributes);
    Task<IReadOnlyList<Product>> GetAllAsync(int skip, int take, IEnumerable<Expression<Func<Product, bool>>> criterias);
    Task<Product?> GetByIdAsync(string id);
}
