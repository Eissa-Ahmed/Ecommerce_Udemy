namespace Ecommerce.Domain.IRepositories.IBase;

public interface IBaseRepository<T> where T : class
{
    Task<IReadOnlyList<TResult>> GetAllAsync<TResult>(ISpecification<T, TResult> specification);
    Task<TResult> GetByIdAsync<TResult>(ISpecification<T, TResult> specification);
    Task<bool> IsExist(Expression<Func<T, bool>> expression);
    Task<T> CreateAsync(T entity);
    Task<T> UpdateAsync(T entity);
    Task CreateManyAsync(List<T> entities);
    Task DeleteAsync(string id);
}
