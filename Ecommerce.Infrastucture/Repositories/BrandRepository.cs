

namespace Ecommerce.Infrastucture.Repositories;

public sealed class BrandRepository : BaseRepository<Brand>, IBrandRepository
{
    private readonly ApplicationDbContext _context;
    public BrandRepository(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }

    public bool hasProducts(string brandId)
    {
        return _context.Products.Any(p => p.BrandId == brandId);
    }
}
