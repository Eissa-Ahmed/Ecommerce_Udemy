namespace Ecommerce.Domain.IRepositories.IUnitOfWork;

public interface IUnitOfWork : IDisposable
{
    IProductRepository ProductRepository { get; }
    Task<int> SaveChangesAsync();

}
