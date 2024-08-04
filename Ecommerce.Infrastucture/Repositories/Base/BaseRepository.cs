
namespace Ecommerce.Infrastucture.Repositories.Base;

public class BaseRepository<T> : IBaseRepository<T> where T : class
{
    private readonly ApplicationDbContext _context;
    public BaseRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<T> CreateAsync(T entity)
    {
        await _context.AddAsync(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task CreateManyAsync(List<T> entities)
    {
        await _context.AddRangeAsync(entities);
        await _context.SaveChangesAsync();
    }

    public virtual async Task DeleteAsync(T entity)
    {
        _context.Set<T>().Remove(entity);
        await _context.SaveChangesAsync();
    }

    public async Task<IReadOnlyList<T>> GetAllAsync(ISpecification<T> specification)
    {
        return await ApplySpecification(specification).ToListAsync();
    }

    public async Task<T?> GetByIdAsync(ISpecification<T> specification)
    {
        return await ApplySpecification(specification).FirstOrDefaultAsync();
    }

    public async Task<T> UpdateAsync(T entity)
    {
        _context.Set<T>().Update(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    private IQueryable<T> ApplySpecification(ISpecification<T> spec)
    {
        return SpecificationEvaliator<T>.GetQuery(_context.Set<T>().AsQueryable(), spec);
    }
}
