namespace Ecommerce.Infrastucture.Repositories.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationDbContext _context;
    public IProductRepository ProductRepository { get; private set; }

    public ICategoryRepository CategoryRepository { get; private set; }

    public IBrandRepository BrandRepository { get; private set; }
    public IAttributesRepository AttributesRepository { get; private set; }

    public ITagRepository TagRepository { get; private set; }

    public IDiscountRepository DiscountRepository { get; private set; }

    public UnitOfWork(ApplicationDbContext context)
    {
        _context = context;
        ProductRepository = new ProductRepository(context);
        CategoryRepository = new CategoryRepository(context);
        BrandRepository = new BrandRepository(context);
        AttributesRepository = new AttributesRepository(context);
        TagRepository = new TagRepository(context);
        DiscountRepository = new DiscountRepository(context);
    }

    public async Task<int> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync();
    }

    public void Dispose()
    {
        _context.Dispose();
    }

    public async Task<IDbContextTransaction> BeginTransactionAsync()
    {
        return await _context.Database.BeginTransactionAsync();
    }

    public async Task CommitTransactionAsync()
    {
        await _context.Database.CommitTransactionAsync();
    }
    public async Task RollbackTransactionAsync()
    {
        await _context.Database.RollbackTransactionAsync();
    }
}
