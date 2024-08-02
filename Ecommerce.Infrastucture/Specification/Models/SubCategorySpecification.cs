namespace Ecommerce.Infrastucture.Specification.Models;

public sealed class SubCategorySpecification : Specification<SubCategory>
{
    public SubCategorySpecification(string subCategoryName) : base(i => i.Name == subCategoryName)
    {

    }
}
