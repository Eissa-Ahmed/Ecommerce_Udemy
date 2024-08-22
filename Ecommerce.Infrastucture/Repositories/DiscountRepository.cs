
namespace Ecommerce.Infrastucture.Repositories;

public sealed class DiscountRepository : BaseRepository<Discount>, IDiscountRepository
{
    public DiscountRepository(ApplicationDbContext context) : base(context)
    {
    }
}
