namespace Ecommerce.Domain.ISpecification;

public interface ISpecification<T>
{
    public Expression<Func<T, bool>>? Criteria { get; }
    public List<Expression<Func<T, object>>> OrderBy { get; }
    public List<Expression<Func<T, object>>> OrderByDescending { get; }
    public Func<IQueryable<T>, IIncludableQueryable<T, object>>? IInclude { get; }
    public int PageNumber { get; }
    public int PageSize { get; }
    public bool IsPagingEnabled { get; }
    public bool AsTracking { get; }
}
