namespace Ecommerce.Application.Services.NotificationContainer;

public sealed class NotificationFactory
{
    private readonly UserManager<User> _userManager;
    private readonly IOptions<EmailSettings> _emailSettings;

    public NotificationFactory(UserManager<User> userManager, IOptions<EmailSettings> emailSettings)
    {
        _userManager = userManager;
        _emailSettings = emailSettings;
    }

    public Task SendNotification(MessageModel message, MessageType messageType)
    {
        switch (messageType)
        {
            case MessageType.Email:
                return new EmailService(_userManager, _emailSettings).SendNotification(message);
            default:
                return Task.CompletedTask;
        }
    }
}
