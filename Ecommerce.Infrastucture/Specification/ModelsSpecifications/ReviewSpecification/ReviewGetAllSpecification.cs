namespace Ecommerce.Infrastucture.Specification.ModelsSpecifications.ReviewSpecification;

public sealed class ReviewGetAllSpecification : Specification<Review>
{
    public ReviewGetAllSpecification(int pageNumber, int pageSize)
    {
        ApplyPaging(pageNumber, pageSize);

        AddIInclude(i => i.Include(p => p.User));
    }
}
