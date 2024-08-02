namespace Ecommerce.Domain.IRepositories;

public interface ICategoryRepository : IBaseRepository<Category>
{
    public Task<Category> GetByIdAsync2(string name);
}
