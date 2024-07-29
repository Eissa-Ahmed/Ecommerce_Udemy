namespace Ecommerce.Domain.IRepositories.IBase;

public interface IBaseRepository<T> where T : class
{
    Task<IEnumerable<T>> GetAllAsync(int take = 0, int skip = 0, Expression<Func<T, bool>>? filter = null);
    Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null);

}
