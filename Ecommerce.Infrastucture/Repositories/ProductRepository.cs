namespace Ecommerce.Infrastucture.Repositories;

public sealed class ProductRepository : BaseRepository<Product>, IProductRepository
{
    private readonly ApplicationDbContext _context;
    public ProductRepository(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }

    public async Task<Product?> GetByIdAsync(string Id)
    {
        return await _context.Products
            .Include(i => i.Category)
            .Include(i => i.Brand)
            .Include(i => i.Images)
            .Include(i => i.ProductAttributes)
            .FirstOrDefaultAsync(i => i.Id == Id);
    }
}
