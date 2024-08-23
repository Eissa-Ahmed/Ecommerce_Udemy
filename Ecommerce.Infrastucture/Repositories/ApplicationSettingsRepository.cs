namespace Ecommerce.Infrastucture.Repositories;

public sealed class ApplicationSettingsRepository : BaseRepository<ApplicationSettings>, IApplicationSettingsRepository
{
    private readonly ApplicationDbContext _context;
    public ApplicationSettingsRepository(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }

    public async Task<ApplicationSettings> GetAsync()
    {
        return (await _context.AppSettings.Include(i => i.SocialMediaAccounts).FirstOrDefaultAsync())!;
    }
}

