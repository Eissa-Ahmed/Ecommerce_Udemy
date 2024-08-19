
namespace Ecommerce.Infrastucture.Repositories;

public sealed class AttributesRepository : BaseRepository<Attributes>, IAttributesRepository
{
    public AttributesRepository(ApplicationDbContext context) : base(context)
    {
    }
}

