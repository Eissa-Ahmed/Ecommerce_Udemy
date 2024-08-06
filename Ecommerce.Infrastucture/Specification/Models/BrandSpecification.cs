namespace Ecommerce.Infrastucture.Specification.Models;

public sealed class BrandSpecification : Specification<Brand>
{
    public BrandSpecification(List<Expression<Func<Brand, bool>>> criterias, bool applyTracking = false) : base(criterias)
    {
        ApplyTracking(applyTracking);
    }
    public BrandSpecification(List<Expression<Func<Brand, bool>>> criterias, List<Expression<Func<Brand, object>>> Includes, bool applyTracking = false) : base(criterias)
    {
        ApplyTracking(applyTracking);
        foreach (var Include in Includes)
        {
            AddInclude(Include);
        }
    }
    public BrandSpecification(bool applyTracking = false)
    {
        ApplyTracking(applyTracking);
    }

}

