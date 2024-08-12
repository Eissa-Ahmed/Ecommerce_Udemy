namespace Ecommerce.Application.Services.IServices.IProductContainer;

public interface IProductService
{
    Task<Product> CreateAsync(Product product);
    Task<Pagination<Product>> GetAllAsync(int pageNumber, int pageSize, string? sortByPrice = null, IEnumerable<Expression<Func<Product, bool>>>? criterias = null);
    Task<Product?> GetByIdAsync(string id);
    //Task<IReadOnlyList<Product>> SearchAsync(string name, string? categoryId = null, string? brandId = null);
}
