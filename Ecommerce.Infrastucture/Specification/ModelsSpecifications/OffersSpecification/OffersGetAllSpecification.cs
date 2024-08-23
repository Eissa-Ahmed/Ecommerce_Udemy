namespace Ecommerce.Infrastucture.Specification.ModelsSpecifications.OffersSpecification;

public sealed class OffersGetAllSpecification : Specification<Discount, Discount>
{
    public OffersGetAllSpecification(int pageNumber, int pageSize) : base(i => i.StartDate.Date < DateTime.UtcNow.Date && i.EndDate.Date > DateTime.UtcNow.Date)
    {
        ApplyPaging(pageNumber, pageSize);
    }
}
