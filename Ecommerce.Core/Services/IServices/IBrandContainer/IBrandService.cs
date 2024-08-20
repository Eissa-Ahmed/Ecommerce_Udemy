namespace Ecommerce.Application.Services.IServices.IBrandContainer;

public interface IBrandService
{
    Task<Pagination<Brand>> GetAllAsync();
    Task<Brand> GetByIdAsync(string brandId);
    Task<Brand> CreateAsync(Brand brand);
    Task<Brand> UpdateAsync(Brand brand);
    Task DeleteAsync(string brandId);
}
