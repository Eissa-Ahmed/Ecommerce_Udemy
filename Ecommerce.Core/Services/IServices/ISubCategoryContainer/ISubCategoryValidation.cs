namespace Ecommerce.Application.Services.IServices.ISubCategoryContainer;

public interface ISubCategoryValidation
{
    public Task<bool> SubCategoryIsExist(string subCategoryName);
}
