namespace Ecommerce.Infrastucture.Seeder;

public class SeedSubCategory
{
    private readonly ApplicationDbContext _context;
    public SeedSubCategory(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task SeedData()
    {
        if (!(await _context.SubCategories.AnyAsync()))
        {
            List<SubCategory> subCategories = SubCategories_SD.GetSubCategories();
            await _context.SubCategories.AddRangeAsync(subCategories);
            await _context.SaveChangesAsync();
        }
    }
}