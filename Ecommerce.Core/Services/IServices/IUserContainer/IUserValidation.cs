namespace Ecommerce.Application.Services.IServices.IUserContainer;

public interface IUserValidation
{
    Task<bool> EmailIsSubscribed(string email);
}
