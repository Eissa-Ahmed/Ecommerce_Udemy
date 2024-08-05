namespace Ecommerce.Infrastucture.Specification.Models;

public sealed class ProductSpecification : Specification<Product>
{
    public ProductSpecification(int pageNumber, int pageSize)
    {
        ApplyPaging(pageNumber, pageSize);
        AddInclude(x => x.Ratings);
    }
    public ProductSpecification(int pageNumber, int pageSize, List<Expression<Func<Product, bool>>> criterias) : base(criterias)
    {
        ApplyPaging(pageNumber, pageSize);
        AddInclude(x => x.Ratings);

    }
    public ProductSpecification(List<Expression<Func<Product, bool>>> criterias, bool applyTracking = false) : base(criterias)
    {
        ApplyTracking(applyTracking);
        AddInclude(x => x.Category);
        AddInclude(x => x.Brand);
        AddInclude(x => x.Images);
        AddIInclude(x => x.Include(i => i.ProductAttributes).ThenInclude(i => i.Attributes));
        AddInclude(x => x.Reviews);
        AddInclude(x => x.Ratings);
    }
}
