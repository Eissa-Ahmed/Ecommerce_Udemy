
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
        return await _context.Categories.AsNoTracking().AnyAsync(i => i.Products.Any(i => i.CategoryName == name));
    }
    public override async Task DeleteAsync(Category category)
    {
        if (category.SubCategories.Count > 0)
        {
            await DeleteSubCategoriesAsync(category.SubCategories);
        }
        _context.Categories.Remove(category);
        await _context.SaveChangesAsync();
    }

    private async Task DeleteSubCategoriesAsync(ICollection<Category> subCategories)
    {
        foreach (var subCategory in subCategories)
        {
            if (subCategory.SubCategories.Count > 0)
                await DeleteSubCategoriesAsync(subCategory.SubCategories);
        }
        _context.RemoveRange(subCategories);
    }
}
