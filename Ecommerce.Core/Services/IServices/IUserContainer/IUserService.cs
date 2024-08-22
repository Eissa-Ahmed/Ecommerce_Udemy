namespace Ecommerce.Application.Services.IServices.IUserContainer;

public interface IUserService
{
    Task<User> GetByIdAsync(string id);
    Task UserSubscriptionAsync(string email);
}
