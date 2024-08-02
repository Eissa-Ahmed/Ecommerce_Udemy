namespace Ecommerce.Infrastucture.Specification;

public class SpecificationEvaliator<T> where T : class
{
    public static IQueryable<T> GetQuery(IQueryable<T> inputQuery, ISpecification<T> spec)
    {
        var query = inputQuery;
        if (spec.Criteria != null)
        {
            query = query.Where(spec.Criteria);
        }

        if (spec.IsPagingEnabled)
        {
            query = query.Skip(spec.Skip).Take(spec.Take);
        }

        query = spec.Includes.Aggregate(query, (current, include) => current.Include(include));
        query = spec.IIncludes.Aggregate(query, (current, include) => include(current));

        return query;
    }
}
