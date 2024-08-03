namespace Ecommerce.Domain.IRepositories;

public interface ICategoryRepository : IBaseRepository<Category>
{
    public Task<bool> CategoryHasProduct(string name);
}
