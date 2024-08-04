namespace Ecommerce.Infrastucture.Specification;

public class Specification<T> : ISpecification<T> where T : class
{
    public Specification() { }
    public Specification(Expression<Func<T, bool>> criteria)
    {
        Criteria = criteria;
    }
    public Expression<Func<T, bool>>? Criteria { get; private set; } = null;

    public List<Expression<Func<T, object>>> Includes { get; } = new List<Expression<Func<T, object>>>();

    public List<Func<IQueryable<T>, IIncludableQueryable<T, object>>> IIncludes { get; } = new List<Func<IQueryable<T>, IIncludableQueryable<T, object>>>();
    public int Take { get; private set; }

    public int Skip { get; private set; }

    public bool IsPagingEnabled { get; private set; }

    public bool AsTracking { get; private set; } = false;

    protected void AddInclude(Expression<Func<T, object>> includeExpression)
    {
        Includes.Add(includeExpression);
    }
    protected void AddIInclude(Func<IQueryable<T>, IIncludableQueryable<T, object>> includeExpression)
    {
        IIncludes.Add(includeExpression);
    }

    public void ApplyPaging(int skip, int take)
    {
        Skip = skip;
        Take = take;
        IsPagingEnabled = true;
    }
    public void ApplyTracking(bool tracking)
    {
        AsTracking = tracking;
    }
}
