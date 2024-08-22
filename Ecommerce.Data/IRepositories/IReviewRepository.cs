namespace Ecommerce.Domain.IRepositories;

public interface IReviewRepository : IBaseRepository<Review>
{
    Task<int> CountAsync();
}

