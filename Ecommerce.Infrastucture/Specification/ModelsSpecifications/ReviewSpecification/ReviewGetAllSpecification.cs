namespace Ecommerce.Infrastucture.Specification.ModelsSpecifications.ReviewSpecification;

public sealed class ReviewGetAllSpecification : Specification<Review, Review>
{
    public ReviewGetAllSpecification(int pageNumber, int pageSize)
    {
        ApplyPaging(pageNumber, pageSize);

        AddInclude(i => i.Include(p => p.User));
    }
}
