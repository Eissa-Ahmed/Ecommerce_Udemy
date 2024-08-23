namespace Ecommerce.Domain.IRepositories;

public interface IDiscountRepository : IBaseRepository<Discount>
{
    Task<int> CountAsync();
}
