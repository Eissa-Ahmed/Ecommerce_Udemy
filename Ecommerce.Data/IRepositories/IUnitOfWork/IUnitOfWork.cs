namespace Ecommerce.Domain.IRepositories.IUnitOfWork;

public interface IUnitOfWork : IDisposable
{
    IProductRepository ProductRepository { get; }
    ICategoryRepository CategoryRepository { get; }
    IBrandRepository BrandRepository { get; }
    IAttributesRepository AttributesRepository { get; }
    ITagRepository TagRepository { get; }
    IReviewRepository ReviewRepository { get; }
    IDiscountRepository DiscountRepository { get; }
    IApplicationSettingsRepository AppSettingsRepository { get; }
    ISubscriptionRepository SubscriptionRepository { get; }
    Task<int> SaveChangesAsync();
    Task<IDbContextTransaction> BeginTransactionAsync();
    Task CommitTransactionAsync();
    Task RollbackTransactionAsync();
}
