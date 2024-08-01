namespace Ecommerce.Infrastucture.Specification.Models;

public sealed class CategorySpecification : Specification<Category>
{
    public CategorySpecification()
    {
        AddInclude(i => i.SubCategories);
        AddInclude(i => i.SubCategories);
    }
}
