namespace Ecommerce.Infrastucture.Specification;

public class Specification<T> : ISpecification<T> where T : class
{
    public Specification() { }
    public Specification(Expression<Func<T, bool>> criteria)
    {
        Criteria = criteria;
    }
    public Specification(int skip, int take)
    {
        Skip = skip;
        Take = take;
        IsPagingEnabled = true;
    }

    public Expression<Func<T, bool>>? Criteria { get; private set; } = null;

    public List<Expression<Func<T, object>>> Includes { get; } = new List<Expression<Func<T, object>>>();

    public int Take { get; private set; }

    public int Skip { get; private set; }

    public bool IsPagingEnabled { get; private set; }

    protected void AddInclude(Expression<Func<T, object>> includeExpression)
    {
        Includes.Add(includeExpression);
    }

    /* public void ApplyPaging(int skip, int take)
     {
         Skip = skip;
         Take = take;
         IsPagingEnabled = true;
     }*/
}
