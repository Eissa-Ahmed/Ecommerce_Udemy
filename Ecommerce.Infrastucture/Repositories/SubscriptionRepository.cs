namespace Ecommerce.Infrastucture.Repositories;

public sealed class SubscriptionRepository : BaseRepository<Subscription>, ISubscriptionRepository
{
    private readonly ApplicationDbContext _context;
    public SubscriptionRepository(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }

    public async Task<bool> IsExistByEmail(string email)
    {
        return await _context.Subscription.AnyAsync(i => i.User.Email == email);
    }
}