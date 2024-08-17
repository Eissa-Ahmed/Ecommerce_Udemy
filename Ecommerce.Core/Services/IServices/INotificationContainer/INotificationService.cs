namespace Ecommerce.Application.Services.IServices.INotificationContainer;

public interface INotificationService
{
    public Task SendNotification(MessageModel message);
}
