namespace Ecommerce.Application.Services.IServices.IAppSettingsContainer;

public interface IAppSettingsService
{
    Task<AppSettings> UpdateAsync(AppSettings appSettings);
    Task<AppSettings> GetAsync();
}
