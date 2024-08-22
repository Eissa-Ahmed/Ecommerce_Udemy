namespace Ecommerce.Infrastucture.Repositories;

public sealed class ReviewRepository : BaseRepository<Review>, IReviewRepository
{
    private readonly ApplicationDbContext _context;
    public ReviewRepository(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }
    public async Task<int> CountAsync()
    {
        return await _context.Review.CountAsync();
    }
}

