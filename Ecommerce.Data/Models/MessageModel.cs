namespace Ecommerce.Domain.Models;

public sealed class MessageModel
{
    public string UserId { get; set; } = null!;
    public string Title { get; set; } = null!;
    public string Message { get; set; } = null!;
}
