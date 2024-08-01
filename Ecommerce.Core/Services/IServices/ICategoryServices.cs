namespace Ecommerce.Application.Services.IServices;

public interface ICategoryServices
{
    Task<IReadOnlyList<Category>> GetAllAsync();
}
