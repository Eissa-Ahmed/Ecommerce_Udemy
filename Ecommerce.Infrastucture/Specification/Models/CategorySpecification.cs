namespace Ecommerce.Infrastucture.Specification.Models;

public sealed class CategorySpecification : Specification<Category>
{
    public CategorySpecification()
    {
    }
    public CategorySpecification(Expression<Func<Category, bool>> criteria, bool applyTracking = false) : base(criteria)
    {
        ApplyTracking(applyTracking);
    }
}
