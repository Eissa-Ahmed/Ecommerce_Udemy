namespace Ecommerce.Domain.IRepositories;

public interface IApplicationSettingsRepository : IBaseRepository<ApplicationSettings>
{
    Task<ApplicationSettings> GetAsync();
}
