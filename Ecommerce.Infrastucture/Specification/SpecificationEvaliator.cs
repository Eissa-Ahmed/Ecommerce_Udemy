namespace Ecommerce.Infrastucture.Specification;

public class SpecificationEvaliator<T> where T : class
{
    public static IQueryable<T> GetQuery(IQueryable<T> inputQuery, ISpecification<T> spec)
    {
        var query = inputQuery;

        if (spec.AsTracking)
            query = query.AsTracking();
        else
            query = query.AsNoTracking();

        if (spec.Criterias.Count > 0)
        {
            query = spec.Criterias.Aggregate(query, (current, criteria) => current.Where(criteria));
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
