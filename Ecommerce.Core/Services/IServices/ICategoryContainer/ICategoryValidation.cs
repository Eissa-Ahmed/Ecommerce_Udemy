namespace Ecommerce.Application.Services.IServices.ICategoryContainer;

public interface ICategoryValidation
{
    public Task<bool> CategoryHasProduct(string Id);
    public Task<bool> CategoryIsExist_ById(string Id);
    public Task<bool> CategoryIsExist_ByName(string name);
    public Task<bool> CategoryHasSubCategory_Or_Product(string name);
    public Task<bool> CategoryHaveSubCategoriesAsync(string Id);
}
