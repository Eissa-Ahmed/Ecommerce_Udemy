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

        if (spec.Criteria != null)
            query = query.Where(spec.Criteria);
        if (spec.OrderBy.Count > 0)
            query = spec.OrderBy.Aggregate(query, (current, orderBy) => current.OrderBy(orderBy));

        if (spec.OrderByDescending.Count > 0)
            query = spec.OrderByDescending.Aggregate(query, (current, orderByDesc) => current.OrderByDescending(orderByDesc));

        if (spec.IsPagingEnabled)
        {
            int skip = (spec.PageNumber - 1) * spec.PageSize;
            query = query.Skip(skip).Take(spec.PageSize);
        }

        query = spec.IInclude != null ? spec.IInclude(query) : query;
        return query;
    }
}
