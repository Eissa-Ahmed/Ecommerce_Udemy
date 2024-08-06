﻿/*namespace Ecommerce.Application.Services.AuthenticationContainer;

public sealed class AuthenticationService : IAuthenticationService
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;
    private readonly ITokenService _tokenService;
    private readonly JWTModel _jWTModel;
    private readonly EmailService _emailService;
    private readonly NotificationManager _notificationManager;
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly IRequestService _requestService;
    private readonly SocialModel _socialModel;
    public AuthenticationService(
        UserManager<ApplicationUser> userManager,
        SignInManager<ApplicationUser> signInManager,
        ITokenService tokenService,
        JWTModel jWTModel,
        EmailService emailService,
        IHttpContextAccessor httpContextAccessor
,
        SocialModel socialModel,
        IRequestService requestService)
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _tokenService = tokenService;
        _jWTModel = jWTModel;
        _emailService = emailService;
        _notificationManager = new NotificationManager(_emailService!);
        _httpContextAccessor = httpContextAccessor;
        _socialModel = socialModel;
        _requestService = requestService;
    }
    public async Task<string?> RegisterAsync(RegisterModel model)
    {
        await createUser(model);
        ApplicationUser? user = await _userManager.FindByEmailAsync(model.Email);
        await _notificationManager.Notify("Message From Application , Welcome You", user!.Id);
        return null;
    }
    public async Task<AuthenticationModel> LoginAsync(LoginModel model)
    {
        ApplicationUser? user = await _userManager.FindByEmailAsync(model.Email);
        if (user is null || !await _userManager.CheckPasswordAsync(user, model.Password))
            return new AuthenticationModel { Message = "Email or password is incorrect.", IsAuthenticated = false };

        return new AuthenticationModel
        {
            IsAuthenticated = true,
            Id = user.Id!,
            Email = user.Email!,
            Token = _tokenService.GenerateToken(user),
            TokenExpiration = DateTime.UtcNow.AddMinutes(_jWTModel.ExpireMinutes),
            RefreshToken = string.Empty,
            RefreshTokenExpiration = DateTime.UtcNow.AddMinutes(_jWTModel.RefreshExpireMinutes)
        };
    }
    public async Task<AuthenticationModel> ContinueWithGoogleAsync(string token)
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
    }
    private async Task createUser(RegisterModel model)
    {
        IdentityResult result = new();
        if (model.Password is not null)
        {
            result = await _userManager.CreateAsync(new ApplicationUser
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                UserName = model.UserName,
            }, model.Password!);
        }
        else
        {
            result = await _userManager.CreateAsync(new ApplicationUser
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                UserName = model.UserName,
            });
        }

        if (!result.Succeeded)
            throw new ExceptionCreateUser(string.Join(", ", result.Errors.Select(e => e.Description)));
    }
    private async Task<GoogleJsonWebSignature.Payload?> ValidateGoogleToken(string token)
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
    }
    private string generateCode()
    {
        Random random = new Random();
        return random.Next(100000, 999999).ToString();
    }

}
*/