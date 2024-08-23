namespace Ecommerce.Infrastucture.Specification.ModelsSpecifications.BrandSpecification;

public sealed class BrandGetAllSpecification : Specification<Brand, Brand>
{
    public BrandGetAllSpecification(Expression<Func<Brand, bool>> criteria, bool applyTracking = false) : base(criteria)
    {
    }

}

