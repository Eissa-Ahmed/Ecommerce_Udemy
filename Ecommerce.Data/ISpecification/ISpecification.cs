namespace Ecommerce.Domain.ISpecification;

public interface ISpecification<T>
{
    Expression<Func<T, bool>>? Criteria { get; }
    List<Expression<Func<T, object>>> OrderBy { get; }
    List<Expression<Func<T, object>>> OrderByDescending { get; }
    List<Func<IQueryable<T>, IIncludableQueryable<T, object>>> IIncludes { get; }
    int PageNumber { get; }
    int PageSize { get; }
    bool IsPagingEnabled { get; }
    bool AsTracking { get; }
}
