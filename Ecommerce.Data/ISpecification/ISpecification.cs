namespace Ecommerce.Domain.ISpecification;

public interface ISpecification<T>
{
    Expression<Func<T, bool>> Criteria { get; }
    List<Expression<Func<T, object>>> Includes { get; }
    List<Func<IQueryable<T>, IIncludableQueryable<T, object>>> IIncludes { get; }
    int Take { get; }
    int Skip { get; }
    bool IsPagingEnabled { get; }
}
