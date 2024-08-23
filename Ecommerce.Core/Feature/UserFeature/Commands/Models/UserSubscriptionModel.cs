namespace Ecommerce.Application.Feature.UserFeature.Commands.Models;

public sealed class UserSubscriptionModel(string Email) : IRequest<ApplicationResponse<string>>
{
    public string Email { get; set; } = Email;
}
