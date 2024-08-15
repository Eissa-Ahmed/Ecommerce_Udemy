namespace Ecommerce.Application.Services.NotificationContainer;

public sealed class NotificationFactory
{
    private INotificationService? _notificationService = null;
    public void SetNotificationService(INotificationService notificationService)
    {
        _notificationService = notificationService;
    }
    public Task SendNotification(string message, string userId)
    {
        if (_notificationService is not null)
            return _notificationService!.SendNotification(message, userId);

        return Task.CompletedTask;
    }
}
