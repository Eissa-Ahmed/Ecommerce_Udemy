namespace Ecommerce.Domain.IRepositories;

public interface IBrandRepository : IBaseRepository<Brand>
{
    bool hasProducts(string brandId);
}
