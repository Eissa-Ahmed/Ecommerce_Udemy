namespace Ecommerce.Application.Services.IServices.ICategoryContainer;

public interface ICategoryValidation
{
    public Task<bool> CategoryIsExist(string name);
    public Task<bool> CategoryHasSubCategory_Or_Product(string name);
}
