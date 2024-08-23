namespace Ecommerce.Application.Services.IServices.IApplicationSettingsContainer;

public interface IApplicationSettingsService
{
    Task<Domain.Entities.ApplicationSettings> UpdateAsync(Domain.Entities.ApplicationSettings appSettings);
    Task<Domain.Entities.ApplicationSettings> GetAsync();
}
