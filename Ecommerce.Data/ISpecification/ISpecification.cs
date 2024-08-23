namespace Ecommerce.Domain.ISpecification;
/*
public interface ISpecification<T>
{
    public Expression<Func<T, bool>>? Criteria { get; }
    public List<Expression<Func<T, object>>> OrderBy { get; }
    public List<Expression<Func<T, object>>> OrderByDescending { get; }
    public Func<IQueryable<T>, IIncludableQueryable<T, object>>? IInclude { get; }
    public Expression<Func<T, object>>? Selector { get; }
    public int PageNumber { get; }
    public int PageSize { get; }
    public bool IsPagingEnabled { get; }
    public bool AsTracking { get; }
}*/

public interface ISpecification<T, TResult>
{
    Expression<Func<T, bool>>? Criteria { get; }
    List<Expression<Func<T, object>>> OrderBy { get; }
    List<Expression<Func<T, object>>> OrderByDescending { get; }
    Func<IQueryable<T>, IIncludableQueryable<T, object>>? IInclude { get; }
    Expression<Func<T, TResult>>? Selector { get; }
    int PageNumber { get; }
    int PageSize { get; }
    bool IsPagingEnabled { get; }
    bool AsTracking { get; }
}