namespace Ecommerce.Infrastucture.Repositories;

public sealed class CategoryRepository : BaseRepository<Category>, ICategoryRepository
{
    private readonly ApplicationDbContext _context;
    public CategoryRepository(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }

    public async Task<bool> CategoryHasProduct(string name)
    {
        return await _context.Categories.AnyAsync(i => i.Products.Any(i => i.CategoryName == name));
    }
}
