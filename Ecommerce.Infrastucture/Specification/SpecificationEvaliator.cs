﻿namespace Ecommerce.Infrastucture.Specification;

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

        if (spec.OrderBy.Count > 0)
        {
            query = spec.OrderBy.Aggregate(query, (current, orderBy) => current.OrderBy(orderBy));
        }

        if (spec.OrderByDescending.Count > 0)
        {
            query = spec.OrderByDescending.Aggregate(query, (current, orderByDesc) => current.OrderByDescending(orderByDesc));
        }

        if (spec.IsPagingEnabled)
        {
            query = query.Skip((spec.PageNumber - 1) * spec.PageSize).Take(spec.PageSize);
        }

        query = spec.Includes.Aggregate(query, (current, include) => current.Include(include));
        query = spec.IIncludes.Aggregate(query, (current, include) => include(current));

        return query;
    }
}
