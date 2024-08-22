
namespace Ecommerce.Infrastucture.Repositories;

public sealed class SubscriptionRepository : BaseRepository<Subscription>, ISubscriptionRepository
{
    public SubscriptionRepository(ApplicationDbContext context) : base(context)
    {
    }
}