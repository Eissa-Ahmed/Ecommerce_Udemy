namespace Ecommerce.Infrastucture.Specification.ModelsSpecifications.BrandSpecification;

public sealed class BrandSpecification : Specification<Brand>
{
    public BrandSpecification(List<Expression<Func<Brand, bool>>> criterias, bool applyTracking = false) : base()
    {
        //ApplyTracking(applyTracking);
    }
    public BrandSpecification(List<Expression<Func<Brand, bool>>> criterias, List<Expression<Func<Brand, object>>> Includes, bool applyTracking = false) : base()
    {
        /*ApplyTracking(applyTracking);
        foreach (var Include in Includes)
        {
            AddInclude(Include);
        }*/
    }
    public BrandSpecification(bool applyTracking = false)
    {
        //ApplyTracking(applyTracking);
    }

}

