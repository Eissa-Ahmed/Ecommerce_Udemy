
namespace Ecommerce.Infrastucture.Repositories;

public sealed class BrandRepository : BaseRepository<Brand>, IBrandRepository
{
    public BrandRepository(ApplicationDbContext context) : base(context)
    {
    }
}
