
namespace Ecommerce.Application.Services.NotificationContainer;

public sealed class EmailService : INotificationService
{
    private readonly UserManager<User> _userManager;
    private readonly IOptions<EmailSettings> _emailSettings;

    public EmailService(UserManager<User> userManager, IOptions<EmailSettings> emailSettings)
    {
        _userManager = userManager;
        _emailSettings = emailSettings;
    }

    public async Task SendNotification(string message, string userId)
    {
        string email = await GetEmailUser(userId);
        MimeMessage mimeMessage = generateMessage(message, email);

        using var emailClient = new SmtpClient();
        await emailClient.ConnectAsync(_emailSettings.Value.host, _emailSettings.Value.port, false);
        await emailClient.AuthenticateAsync(_emailSettings.Value.fromEmail, _emailSettings.Value.password);
        await emailClient.SendAsync(mimeMessage);
        await emailClient.DisconnectAsync(true);
    }

    private MimeMessage generateMessage(string message, string email)
    {
        MimeMessage mimeMessage = new MimeMessage();
        mimeMessage.From.Add(new MailboxAddress(_emailSettings.Value.fromName, _emailSettings.Value.fromEmail));
        mimeMessage.To.Add(new MailboxAddress(email.Split('@')[0], email));
        mimeMessage.Subject = "Notification";
        mimeMessage.Body = new TextPart
        {
            Text = message
        };
        return mimeMessage;
    }

    private async Task<string> GetEmailUser(string userId)
    {
        User? user = await _userManager.FindByIdAsync(userId);
        return user!.Email!;
    }
}
