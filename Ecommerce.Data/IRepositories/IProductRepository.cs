using Ecommerce.Domain.Entities;
namespace Ecommerce.Domain.IRepositories;

public interface IProductRepository : IBaseRepository<Product>
{
    Task<Product?> GetByIdAsync(string Id);
}
