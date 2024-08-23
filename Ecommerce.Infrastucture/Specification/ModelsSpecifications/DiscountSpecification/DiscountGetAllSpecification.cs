namespace Ecommerce.Infrastucture.Specification.ModelsSpecifications.DiscountSpecification;

public sealed class DiscountGetAllSpecification : Specification<Discount, Discount>
{
    public DiscountGetAllSpecification(int pageNumber, int pageSize)
    {
        ApplyPaging(pageNumber, pageSize);
    }
}
