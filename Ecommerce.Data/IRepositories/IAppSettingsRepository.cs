namespace Ecommerce.Domain.IRepositories;

public interface IAppSettingsRepository : IBaseRepository<AppSettings>
{
    Task<AppSettings> GetAsync();
}
