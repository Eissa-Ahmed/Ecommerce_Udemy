namespace Ecommerce.Infrastucture.Specification.Models;

public sealed class CategorySpecification : Specification<Category>
{
    public CategorySpecification() : base(i => i.ParentCategoryName == null)
    {
        AddIInclude(i => i.Include(c => c.SubCategories)
        .ThenInclude(sc => sc.SubCategories)
        .ThenInclude(sc => sc.SubCategories));
    }
    public CategorySpecification(string name) : base(i => i.Name == name)
    {
        AddIInclude(i => i.Include(c => c.SubCategories.Where(i => i.ParentCategoryName == null))
            .ThenInclude(sc => sc.SubCategories)
            .ThenInclude(sc => sc.SubCategories));
    }
}
