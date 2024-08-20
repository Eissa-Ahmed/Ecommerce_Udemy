namespace Ecommerce.Infrastucture.Specification.ModelsSpecifications.BrandSpecification;

public sealed class BrandGetAllSpecification : Specification<Brand>
{
    public BrandGetAllSpecification(List<Expression<Func<Brand, bool>>> criterias, bool applyTracking = false) : base()
    {
    }

}

