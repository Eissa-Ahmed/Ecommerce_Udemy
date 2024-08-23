namespace Ecommerce.Application.Services.AppSettingsContainer;

public sealed class AppSettingsService : IApplicationSettingsService
{
    private readonly IUnitOfWork _unitOfWork;

    public AppSettingsService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public Task<Domain.Entities.ApplicationSettings> GetAsync()
    {
        return _unitOfWork.AppSettingsRepository.GetAsync();
    }

    public async Task<Domain.Entities.ApplicationSettings> UpdateAsync(Domain.Entities.ApplicationSettings appSettings)
    {
        return await _unitOfWork.AppSettingsRepository.UpdateAsync(appSettings);
    }
}
