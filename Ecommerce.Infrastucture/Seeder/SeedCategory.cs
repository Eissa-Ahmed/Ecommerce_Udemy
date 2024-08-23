namespace Ecommerce.Infrastucture.Seeder;

public sealed class SeedCategory
{
    private readonly ApplicationDbContext _context;
    public SeedCategory(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task SeedData()
    {
        if (!(await _context.Categories.AnyAsync()))
        {
            List<Category> categories = Categories_SD.GetCategories();
            await _context.Categories.AddRangeAsync(categories);
            await _context.SaveChangesAsync();
        }
    }
}
