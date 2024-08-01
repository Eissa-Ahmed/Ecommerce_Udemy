using Ecommerce.Application.Model;

namespace Ecommerce.Application.Services.IServices;

public interface ICategoryServices
{
    Task<IReadOnlyList<CategoryModel>> GetAllAsync();
}
