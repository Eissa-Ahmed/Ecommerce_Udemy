namespace Ecommerce.Infrastucture.Seeder;

public sealed class SeedAppSettings
{
    private readonly ApplicationDbContext _context;
    public SeedAppSettings(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task SeedData()
    {
        if (!(await _context.AppSettings.AnyAsync()))
        {
            ApplicationSettings appSettings = new ApplicationSettings
            {
                Address = "مصر , المنصورة - شارع قناة السويس",
                Email = "admin@krist.com",
                MinimumFreeShipping = 1000,
                SocialMediaAccounts = new SocialMediaAccounts
                {
                    Facebook = "https://www.facebook.com",
                    X = "https://www.x.com",
                    Instagram = "https://www.instagram.com"
                }
            };
            await _context.AppSettings.AddAsync(appSettings);
            await _context.SaveChangesAsync();
        }
    }
}
