namespace Ecommerce.Infrastucture.Specification.ModelsSpecifications.CategorySpecification;

public sealed class CategoryGetAllSpecification : Specification<Category, Category>
{
    public CategoryGetAllSpecification(Expression<Func<Category, bool>>? criteria = null) : base(criteria)
    {
        //AddIInclude(i => i.Include(p => p.SubCategories).ThenInclude(p => p.SubCategories));
    }
}
