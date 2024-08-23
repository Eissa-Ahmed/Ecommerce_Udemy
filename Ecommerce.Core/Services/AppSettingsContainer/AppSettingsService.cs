namespace Ecommerce.Application.Services.AppSettingsContainer;

public sealed class AppSettingsService : IAppSettingsService
{
    private readonly IUnitOfWork _unitOfWork;

    public AppSettingsService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public Task<AppSettings> GetAsync()
    {
        return _unitOfWork.AppSettingsRepository.GetAsync();
    }

    public async Task<AppSettings> UpdateAsync(AppSettings appSettings)
    {
        return await _unitOfWork.AppSettingsRepository.UpdateAsync(appSettings);
    }
}
