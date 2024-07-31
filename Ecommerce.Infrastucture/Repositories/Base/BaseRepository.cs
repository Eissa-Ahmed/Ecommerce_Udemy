namespace Ecommerce.Infrastucture.Repositories.Base;

public class BaseRepository<T> : IBaseRepository<T> where T : class
{
    private readonly ApplicationDbContext _context;
    public BaseRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<T>> GetAllAsync(int take = 0, int skip = 0, Expression<Func<T, bool>>? filter = null)
    {
        return filter is null
                    ? await _context.Set<T>().AsNoTracking().Skip(skip).Take(take).ToListAsync()
                    : await _context.Set<T>().AsNoTracking().Where(filter).Skip(skip).Take(take).ToListAsync();
    }

    public async Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null)
    {
        return filter is null
                  ? await _context.Set<T>().AsNoTracking().ToListAsync()
                  : await _context.Set<T>().AsNoTracking().Where(filter).ToListAsync();
    }

}
