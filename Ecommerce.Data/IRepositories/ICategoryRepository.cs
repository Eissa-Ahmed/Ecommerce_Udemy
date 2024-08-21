namespace Ecommerce.Domain.IRepositories;

public interface ICategoryRepository : IBaseRepository<Category>
{
    public Task<bool> CategoryHasProduct(string Id);
    public Task<bool> CategoryHaveSubCategoriesAsync(string Id);
    public Task DeleteAsync(Category category);
}
