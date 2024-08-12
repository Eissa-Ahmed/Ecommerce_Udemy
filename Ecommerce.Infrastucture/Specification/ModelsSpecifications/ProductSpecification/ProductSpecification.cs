namespace Ecommerce.Infrastucture.Specification.ModelsSpecifications.ProductSpecification;

public sealed class ProductSpecification : Specification<Product>
{
    public ProductSpecification(Expression<Func<Product, bool>> criteria) : base(criteria)
    {
        /* if (orderBy != null)
             ApplyOrdering(orderBy!);

         if (orderByDesc != null)
             ApplyOrderingDesc(orderByDesc!);

         ApplyPaging(pageNumber, pageSize);*/

    }
    /*public ProductSpecification(List<Expression<Func<Product, bool>>> criterias) : base(criterias)
    {
        AddInclude(x => x.Ratings);
    }*/
    public ProductSpecification(List<Expression<Func<Product, bool>>> criterias, bool applyTracking = false)
    {
        /*ApplyTracking(applyTracking);
        AddInclude(x => x.Category);
        AddInclude(x => x.Brand);
        AddInclude(x => x.Images);
        AddIInclude(x => x.Include(i => i.ProductAttributes).ThenInclude(i => i.Attributes));
        AddInclude(x => x.Reviews);
        AddInclude(x => x.Features);
        AddInclude(x => x.CareInstructions);*/
    }
}
