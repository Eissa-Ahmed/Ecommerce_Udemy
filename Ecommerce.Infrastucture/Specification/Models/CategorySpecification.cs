namespace Ecommerce.Infrastucture.Specification.Models;

public sealed class CategorySpecification : Specification<Category>
{
    public CategorySpecification()
    {
        AddIInclude(i => i.Include(c => c.SubCategories
            .Where(sc => sc.ParentSubcategoryName == null))
            .ThenInclude(sc => sc.SubCategorys)
            .ThenInclude(sc => sc.SubCategorys));
    }
    public CategorySpecification(string name) : base(i => i.Name == name)
    {

    }
}
