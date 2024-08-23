

namespace Ecommerce.Infrastucture.Specification;

/*public class Specification<T> : ISpecification<T> where T : class
{
    public Expression<Func<T, bool>>? Criteria { get; } = null;

    public List<Expression<Func<T, object>>> OrderBy { get; } = new List<Expression<Func<T, object>>>();

    public List<Expression<Func<T, object>>> OrderByDescending { get; } = new List<Expression<Func<T, object>>>();

    public Expression<Func<T, object>>? Selector { get; private set; } = null;
    public Func<IQueryable<T>, IIncludableQueryable<T, object>>? IInclude { get; private set; } = null;

    public int PageNumber { get; private set; }

    public int PageSize { get; private set; }

    public bool IsPagingEnabled { get; private set; }

    public bool AsTracking { get; private set; }


    protected Specification() { }
    protected Specification(Expression<Func<T, bool>>? criteria = null)
    {
        Criteria = criteria;
    }

    protected void AddIInclude(Func<IQueryable<T>, IIncludableQueryable<T, object>> includeExpression)
    {
        IInclude = includeExpression;
    }

    protected void ApplyPaging(int pageNumber, int pageSize)
    {
        PageNumber = pageNumber;
        PageSize = pageSize;
        IsPagingEnabled = true;
    }
    protected void AddOrderBy(Expression<Func<T, object>> orderByExpression)
    {
        OrderBy.Add(orderByExpression);
    }

    protected void AddOrderByDescending(Expression<Func<T, object>> orderByDescendingExpression)
    {
        OrderByDescending.Add(orderByDescendingExpression);
    }

    protected void ApplySelector(Expression<Func<T, object>> selector)
    {
        Selector = selector;
    }

    protected void ApplyNoTracking()
    {
        AsTracking = true;
    }
}*/

public class Specification<T, TResult> : ISpecification<T, TResult> where T : class
{
    public Expression<Func<T, bool>>? Criteria { get; } = null;

    public List<Expression<Func<T, object>>> OrderBy { get; } = new List<Expression<Func<T, object>>>();

    public List<Expression<Func<T, object>>> OrderByDescending { get; } = new List<Expression<Func<T, object>>>();

    public Expression<Func<T, TResult>>? Selector { get; private set; } = null;
    public Func<IQueryable<T>, IIncludableQueryable<T, object>>? IInclude { get; private set; } = null;

    public int PageNumber { get; private set; }

    public int PageSize { get; private set; }

    public bool IsPagingEnabled { get; private set; }

    public bool AsTracking { get; private set; }


    protected Specification() { }
    protected Specification(Expression<Func<T, bool>>? criteria = null)
    {
        Criteria = criteria;
    }

    protected void AddInclude(Func<IQueryable<T>, IIncludableQueryable<T, object>> includeExpression)
    {
        IInclude = includeExpression;
    }

    protected void ApplyPaging(int pageNumber, int pageSize)
    {
        PageNumber = pageNumber;
        PageSize = pageSize;
        IsPagingEnabled = true;
    }

    protected void AddOrderBy(Expression<Func<T, object>> orderByExpression)
    {
        OrderBy.Add(orderByExpression);
    }

    protected void AddOrderByDescending(Expression<Func<T, object>> orderByDescendingExpression)
    {
        OrderByDescending.Add(orderByDescendingExpression);
    }

    protected void ApplySelector(Expression<Func<T, TResult>> selector)
    {
        Selector = selector;
    }

    protected void ApplyNoTracking()
    {
        AsTracking = false;
    }

    protected void ApplyTracking()
    {
        AsTracking = true;
    }
}