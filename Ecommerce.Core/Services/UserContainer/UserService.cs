namespace Ecommerce.Application.Services.UserContainer;

public sealed class UserService : IUserService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly UserManager<User> _userManager;

    public UserService(IUnitOfWork unitOfWork, UserManager<User> userManager)
    {
        _unitOfWork = unitOfWork;
        _userManager = userManager;
    }

    public async Task<ICollection<string>> GetAllUsersSubscribersAsync()
    {
        ISpecification<Subscription, string> userGetAllSubscribersSpecification = new UserGetAllSubscribersSpecification();
        IReadOnlyList<string> usersId = await _unitOfWork.SubscriptionRepository.GetAllAsync(userGetAllSubscribersSpecification);
        return usersId.ToList();
    }

    public async Task<User> GetByIdAsync(string id)
    {
        User? user = await _userManager.Users.Where(i => i.Id == id)
            .Include(i => i.Cart)
            .Include(i => i.Wishlist)
            .Include(i => i.Subscription)
            .Include(i => i.Review)
            .Include(i => i.Address)
            .Include(i => i.Orders)
            .FirstOrDefaultAsync();

        return user!;
    }

    public async Task UserSubscriptionAsync(string email)
    {
        User? user = await _userManager.FindByEmailAsync(email);
        Subscription subscription = new Subscription { UserId = user!.Id };
        await _unitOfWork.SubscriptionRepository.CreateAsync(subscription);
    }
}
