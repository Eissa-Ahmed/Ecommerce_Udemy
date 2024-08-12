namespace Ecommerce.Application.Services.IServices.IProductContainer;

public interface IProductValidation
{
    public Task<bool> ProductIsExist(string Id);
}
