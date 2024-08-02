

namespace Ecommerce.Infrastucture.Repositories;

public sealed class CategoryRepository : BaseRepository<Category>, ICategoryRepository
{
    private readonly ApplicationDbContext _context;
    public CategoryRepository(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }

    public async Task<Category> GetByIdAsync2(string name)
    {
        var result = await _context.Categories.Where(i => i.Name == name)

            .FirstOrDefaultAsync();
        //.Include(i => i.SubCategories.Where(i => i.ParentSubcategoryName == null))
        //.ThenInclude(i => i.SubCategorys)
        /*.ThenInclude(i => i.SubCategorys)
        .ThenInclude(i => i.SubCategorys)*/

        return result!;
    }
}
