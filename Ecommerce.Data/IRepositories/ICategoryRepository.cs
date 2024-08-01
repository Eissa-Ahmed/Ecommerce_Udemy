namespace Ecommerce.Domain.IRepositories;

public interface ICategoryRepository : IBaseRepository<Category>
{
    public Task<IReadOnlyList<Category>> GetAllAsync2();
}
