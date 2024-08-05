namespace Ecommerce.Application.Services.IServices.ICategoryContainer;

public interface ICategoryServices
{
    Task<IReadOnlyList<Category>> GetAllAsync();
    Task<Category> GetByIdAsync(string id);
    Task<Category> CreateAsync(Category category);
    Task<Category> AddSubCategoryInCategoryAsync(Category category);
    Task<Category> UpdateNameAsync(string id, string name);
    Task<Category> TransferProductsFromCurrentCategoryToNestedCategory(string idCurrentCategory, string idNestedCategory);
    Task DeleteAsync(string id);
}
