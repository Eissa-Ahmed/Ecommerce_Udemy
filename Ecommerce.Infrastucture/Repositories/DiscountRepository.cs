namespace Ecommerce.Infrastucture.Repositories;

public sealed class DiscountRepository : BaseRepository<Discount>, IDiscountRepository
{
    private readonly ApplicationDbContext _context;
    public DiscountRepository(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }

    public async Task<int> CountAsync()
    {
        return await _context.Discount.CountAsync();
    }
}
