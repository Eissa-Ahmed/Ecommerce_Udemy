namespace Ecommerce.Domain.IRepositories;

public interface IProductRepository : IBaseRepository<Product>
{
    public Task<int> CountAsync();
}
