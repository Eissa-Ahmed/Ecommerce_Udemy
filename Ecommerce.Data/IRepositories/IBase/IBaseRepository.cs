namespace Ecommerce.Domain.IRepositories.IBase;

public interface IBaseRepository<T> where T : class
{
    Task<IReadOnlyList<T>> GetAllAsync(ISpecification<T> specification);
    Task<T> GetByIdAsync(ISpecification<T> specification);
    Task<T> CreateAsync(T entity);
    Task<T> UpdateAsync(T entity);
    Task CreateManyAsync(List<T> entities);
    Task DeleteAsync(T entity);
}
