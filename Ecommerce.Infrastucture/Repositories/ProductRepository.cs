
namespace Ecommerce.Infrastucture.Repositories;

public sealed class ProductRepository : BaseRepository<Product>, IProductRepository
{
    private readonly ApplicationDbContext _context;
    public ProductRepository(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }

    public async Task<int> CountAsync()
    {
        return await _context.Products.CountAsync();
    }
}
