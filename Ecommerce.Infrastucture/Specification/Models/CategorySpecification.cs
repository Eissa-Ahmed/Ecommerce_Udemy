namespace Ecommerce.Infrastucture.Specification.Models;

public sealed class CategorySpecification : Specification<Category>
{
    public CategorySpecification()
    {
    }
    public CategorySpecification(List<Expression<Func<Category, bool>>> criterias, bool applyTracking = false) : base(criterias)
    {
        ApplyTracking(applyTracking);
    }
}
