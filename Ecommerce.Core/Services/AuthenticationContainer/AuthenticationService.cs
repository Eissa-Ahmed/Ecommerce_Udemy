namespace Ecommerce.Application.Services.AuthenticationContainer;

public sealed class AuthenticationService : IAuthenticationService
{
    private readonly UserManager<User> _userManager;
    private readonly NotificationFactory _notificationFactory;
    private readonly EmailService _emailService;
    private readonly ITokenService _tokenService;
    private readonly IOptions<JWTModel> _jWTModel;
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly IRequestService _requestService;
    private readonly IUnitOfWork _unitOfWork;
    public AuthenticationService(
        UserManager<User> userManager,
        ITokenService tokenService,
        IOptions<JWTModel> jWTModel,
        IHttpContextAccessor httpContextAccessor,
        IRequestService requestService,
        IUnitOfWork unitOfWork,
        NotificationFactory notificationFactory,
        EmailService emailService)
    {
        _userManager = userManager;
        _tokenService = tokenService;
        _jWTModel = jWTModel;
        _httpContextAccessor = httpContextAccessor;
        _requestService = requestService;
        _unitOfWork = unitOfWork;
        _notificationFactory = notificationFactory;
        _emailService = emailService;
    }
    public async Task<string?> RegisterAsync(RegisterModel model)
    {
        await createUser(model);
        User? user = await _userManager.FindByEmailAsync(model.Email);
        sendNotification(user!.Id);

        return null;
    }
    public async Task<AuthenticationModel> LoginAsync(LoginModel model)
    {
        User? user = await _userManager.Users
            .Where(u => u.Email == model.Email)
            .Include(u => u.RefreshToken)
            .FirstOrDefaultAsync();

        string role = _userManager.GetRolesAsync(user!).Result.FirstOrDefault()!;

        if (user is null || !await _userManager.CheckPasswordAsync(user, model.Password))
            return new AuthenticationModel { Message = "Email or password is incorrect.", IsAuthenticated = false };

        RefreshToken refreshToken = await _tokenService.GenerateRefreshToken(user);

        return new AuthenticationModel
        {
            IsAuthenticated = true,
            Id = user.Id!,
            Email = user.Email!,
            Token = _tokenService.GenerateToken(user, role),
            TokenExpiration = DateTime.UtcNow.AddMinutes(_jWTModel.Value.ExpireMinutes),
            RefreshToken = refreshToken.Token,
            RefreshTokenExpiration = refreshToken.Expires
        };
    }
    public async Task<AuthenticationModel> RefreshTokenAsync()
    {
        string? refreshToken = _httpContextAccessor.HttpContext!.Request.Cookies["refreshToken"];
        if (refreshToken is null)
        {
            return new AuthenticationModel
            {
                IsAuthenticated = false,
                Message = "Invalid Refresh Token"
            };
        }
        User? user = await _userManager.Users.Where(i => i.RefreshToken.Any(t => t.Token == refreshToken)).Include(t => t.RefreshToken).FirstOrDefaultAsync();

        if (!user.RefreshToken.Any(i => i.Token == refreshToken && i.IsActive))
        {
            return new AuthenticationModel
            {
                IsAuthenticated = false,
                Message = "Expired Refresh Token"
            };
        }

        string role = _userManager.GetRolesAsync(user!).Result.FirstOrDefault()!;

        RefreshToken refreshTokenModel = await _tokenService.GenerateRefreshToken(user);

        return new AuthenticationModel
        {
            IsAuthenticated = true,
            Id = user.Id!,
            Email = user.Email!,
            Token = _tokenService.GenerateToken(user, role),
            TokenExpiration = DateTime.UtcNow.AddMinutes(_jWTModel.Value.ExpireMinutes),
            RefreshToken = refreshTokenModel.Token,
            RefreshTokenExpiration = refreshTokenModel.Expires
        };
    }
    public async Task<bool> RevokeTokenAsync()
    {
        string? refreshToken = _httpContextAccessor.HttpContext!.Request.Cookies["refreshToken"];
        User? user = await _userManager.Users.Where(i => i.RefreshToken.Any(t => t.Token == refreshToken)).Include(t => t.RefreshToken).FirstOrDefaultAsync();

        if (user is null) return false;

        RefreshToken refreshTokenModel = user.RefreshToken.FirstOrDefault(i => i.Token == refreshToken)!;
        if (!refreshTokenModel.IsActive) return false;

        refreshTokenModel.Revoked = DateTime.UtcNow;

        _httpContextAccessor.HttpContext!.Response.Cookies.Delete("refreshToken");
        user.RefreshToken = user.RefreshToken.Where(i => i.IsActive).ToList();
        await _userManager.UpdateAsync(user);
        return true;
    }

    private async Task createUser(RegisterModel model)
    {
        using var transaction = await _unitOfWork.BeginTransactionAsync();
        try
        {
            User user = new User
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                UserName = model.UserName,
                Cart = new Cart(),
                Wishlist = new Wishlist()
            };
            IdentityResult identityResultCreateUser = await _userManager.CreateAsync(user, model.Password!);

            if (!identityResultCreateUser.Succeeded)
                throw new Exception(string.Join(", ", identityResultCreateUser.Errors.Select(e => e.Description)));

            IdentityResult identityResultAddToRole = await _userManager.AddToRoleAsync(user, RolesType.User.ToString());
            if (!identityResultAddToRole.Succeeded)
                throw new Exception(string.Join(", ", identityResultAddToRole.Errors.Select(e => e.Description)));

            await transaction.CommitAsync();
        }
        catch (Exception ex)
        {
            await transaction.RollbackAsync();
            throw ex;
        }
    }
    private string generateCode()
    {
        Random random = new Random();
        return random.Next(100000, 999999).ToString();
    }
    private void sendNotification(string id)
    {
        _notificationFactory.SetNotificationService(_emailService);
        _notificationFactory.SendNotification("Welcome You In Krist", id);
    }


}
