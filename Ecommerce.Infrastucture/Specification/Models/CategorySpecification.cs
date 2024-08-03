namespace Ecommerce.Infrastucture.Specification.Models;

public sealed class CategorySpecification : Specification<Category>
{
    public CategorySpecification()
    {

    }
    public CategorySpecification(Expression<Func<Category, bool>> criteria) : base(criteria)
    {
    }

}
