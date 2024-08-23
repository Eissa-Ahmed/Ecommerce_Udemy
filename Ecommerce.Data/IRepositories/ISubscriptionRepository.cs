namespace Ecommerce.Domain.IRepositories;

public interface ISubscriptionRepository : IBaseRepository<Subscription>
{
    Task<bool> IsExistByEmail(string email);
}