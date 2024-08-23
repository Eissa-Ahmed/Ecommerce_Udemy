namespace Ecommerce.Application.Services.UserContainer;

public sealed class UserValidation : IUserValidation
{
    private readonly IUnitOfWork _unitOfWork;

    public UserValidation(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<bool> EmailIsSubscribed(string email)
    {
        return await _unitOfWork.SubscriptionRepository.IsExist(i => i.User.Email == email);
    }
}
