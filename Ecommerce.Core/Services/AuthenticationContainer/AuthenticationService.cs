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
    /*    public async Task<AuthenticationModel> ContinueWithGoogleAsync(string token)
        {
            var validateToken = await ValidateGoogleToken(token);
            if (validateToken is null)
                return new AuthenticationModel { Message = "Invalid Token", IsAuthenticated = false };

            ApplicationUser? user = await _userManager.FindByEmailAsync(validateToken.Email);

            if (user is null)
            {
                await createUser(new RegisterModel { Email = validateToken.Email, FirstName = validateToken.GivenName, LastName = validateToken.FamilyName });
                user = await _userManager.FindByEmailAsync(validateToken.Email);
            }
            return new AuthenticationModel
            {
                IsAuthenticated = true,
                Id = user.Id,
                Email = user.Email,
                Token = _tokenService.GenerateToken(user),
                TokenExpiration = DateTime.UtcNow.AddMinutes(_jWTModel.ExpireMinutes),
                RefreshToken = string.Empty,
                RefreshTokenExpiration = DateTime.UtcNow.AddMinutes(_jWTModel.RefreshExpireMinutes)
            };
        }
        public async Task ForgetPasswordAsync(string email)
        {
            ApplicationUser? user = _userManager.FindByEmailAsync(email).Result;
            if (user is null)
                throw new ExceptionUserNotFound();

            string code = generateCode();
            user.Codes.Add(new CodesEntity { Code = code });

            await _notificationManager.Notify(code, user.Id);

            IdentityResult result = await _userManager.UpdateAsync(user);
            if (!result.Succeeded)
                throw new ExceptionUpdateUser("Failed to update user, When generate code");

        }
        public async Task CheckCodeForgetPasswordAsync(string email, string code)
        {
            ApplicationUser? user = await _userManager.Users.Include(u => u.Codes).FirstOrDefaultAsync(u => u.Email == email);
            if (user is null)
                throw new ExceptionUserNotFound();

            CodesEntity? codesEntity = user.Codes.FirstOrDefault(c => c.Code == code);
            if (codesEntity is null || !codesEntity.IsActive)
                throw new ExceptionCodeNotFoundOrNotActive();

            user.Codes.All(i => i.IsUsed = true);
            IdentityResult result = await _userManager.UpdateAsync(user);
            if (!result.Succeeded)
                throw new ExceptionUpdateUser("Failed to update user, When confirm code");
        }
        public async Task ConfirmForgetPasswordAsync(string email, string newPassword)
        {
            ApplicationUser? user = await _userManager.FindByEmailAsync(email);
            if (user is null)
                throw new ExceptionUserNotFound();

            string token = await _userManager.GeneratePasswordResetTokenAsync(user);
            IdentityResult resultChangePassword = await _userManager.ResetPasswordAsync(user, token, newPassword);
            if (!resultChangePassword.Succeeded)
                throw new ExceptionUpdateUser(string.Join(",", resultChangePassword.Errors.Select(m => m.Description)));
        }
        public async Task ResetPasswordAsync(string oldPassword, string newPassword)
        {
            string userId = _requestService.GetUserIdFromToken();
            ApplicationUser? user = await _userManager.FindByIdAsync(userId);
            IdentityResult result = await _userManager.ChangePasswordAsync(user, oldPassword, newPassword);
            if (result.Succeeded)
                throw new ExceptionUpdateUser(string.Join(",", result.Errors.Select(m => m.Description)));
        }*/
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

    /*    private async Task<GoogleJsonWebSignature.Payload?> ValidateGoogleToken(string token)
        {
            try
            {
                var settings = new GoogleJsonWebSignature.ValidationSettings
                {
                    Audience = new List<string> { _socialModel.Google.ClientId }
                };
                var payload = await GoogleJsonWebSignature.ValidateAsync(token, settings);
                return payload;
            }
            catch
            {
                return null;
            }
        }*/
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
