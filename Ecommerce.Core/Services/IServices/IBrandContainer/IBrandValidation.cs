namespace Ecommerce.Application.Services.IServices.IBrandContainer;

public interface IBrandValidation
{
    public Task<bool> BrandIsExist(string brandId);
}
