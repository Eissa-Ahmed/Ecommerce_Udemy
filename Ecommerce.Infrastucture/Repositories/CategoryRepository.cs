
namespace Ecommerce.Infrastucture.Repositories;

public sealed class CategoryRepository : BaseRepository<Category>, ICategoryRepository
{
    private readonly ApplicationDbContext _context;
    public CategoryRepository(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }

    public async Task<IReadOnlyList<Category>> GetAllAsync2()
    {
        return await _context.Categories.Include(i => i.SubCategories).ThenInclude(i => i.SubCategorys).ToListAsync();
    }
}
