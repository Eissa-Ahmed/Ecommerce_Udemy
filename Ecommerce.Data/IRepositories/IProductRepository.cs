using Ecommerce.Domain.Entities;
namespace Ecommerce.Domain.IRepositories;

public interface IProductRepository : IBaseRepository<Products>
{
    Task<Products?> GetByIdAsync(string Id);
}
