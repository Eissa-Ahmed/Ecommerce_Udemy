namespace Ecommerce.Infrastucture.Repositories;

public sealed class SubCategoryRepository : BaseRepository<SubCategory>, ISubCategoryRepository
{
    public SubCategoryRepository(ApplicationDbContext context) : base(context)
    {
    }
}
