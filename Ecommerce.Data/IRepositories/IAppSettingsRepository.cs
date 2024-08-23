namespace Ecommerce.Domain.IRepositories;

public interface IAppSettingsRepository : IBaseRepository<ApplicationSettings>
{
    Task<ApplicationSettings> GetAsync();
}
