namespace Ecommerce.Infrastucture.Specification.ModelsSpecifications.CategorySpecification;

public sealed class CategoryGetByIdSpecification : Specification<Category>
{
    public CategoryGetByIdSpecification(string Id) : base(i => i.Id == Id)
    {
    }
}
