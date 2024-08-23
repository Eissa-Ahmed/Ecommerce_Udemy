namespace Ecommerce.Infrastucture.Specification.ModelsSpecifications.DiscountSpecification;

public sealed class DiscountGetAllSpecification : Specification<Discount>
{
    public DiscountGetAllSpecification(int pageNumber, int pageSize)
    {
        ApplyPaging(pageNumber, pageSize);
    }
}
