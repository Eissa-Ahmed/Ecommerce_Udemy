namespace Ecommerce.Infrastucture.Repositories;

public sealed class AppSettingsRepository : BaseRepository<ApplicationSettings>, IAppSettingsRepository
{
    private readonly ApplicationDbContext _context;
    public AppSettingsRepository(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }

    public async Task<ApplicationSettings> GetAsync()
    {
        return (await _context.AppSettings.FirstOrDefaultAsync())!;
    }
}

