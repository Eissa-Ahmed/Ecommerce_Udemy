namespace Ecommerce.Domain.IRepositories.IUnitOfWork;

public interface IUnitOfWork : IDisposable
{
    IProductRepository ProductRepository { get; }
    ICategoryRepository CategoryRepository { get; }
    IBrandRepository BrandRepository { get; }
    IAttributesRepository AttributesRepository { get; }
    Task<int> SaveChangesAsync();

}
