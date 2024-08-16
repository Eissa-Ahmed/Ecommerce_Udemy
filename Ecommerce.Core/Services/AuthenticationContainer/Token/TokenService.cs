namespace Ecommerce.Application.Services.AuthenticationContainer.Token;

public sealed class TokenService : ITokenService
{
    private readonly UserManager<User> _userManager;
    private readonly IOptions<JWTModel> _jwtModel;
    private readonly IHttpContextAccessor _httpContextAccessor;
    public TokenService(IOptions<JWTModel> jwtModel, UserManager<User> userManager, IHttpContextAccessor httpContextAccessor)
    {
        _jwtModel = jwtModel;
        _userManager = userManager;
        _httpContextAccessor = httpContextAccessor;
    }
    public string GenerateToken(User user, string role)
    {
        SecurityToken securityToken = generateSecurityToken(user, role);
        return new JwtSecurityTokenHandler().WriteToken(securityToken);
    }

    private SecurityToken generateSecurityToken(User user, string role)
    {
        IEnumerable<Claim> claims = generateClaims(user, role);
        SigningCredentials signingCredentials = generateSigningCredentials();
        SecurityToken securityToken = new JwtSecurityToken
        (
            issuer: _jwtModel.Value.Issuer,
            audience: _jwtModel.Value.Audience,
            claims: claims,
            expires: DateTime.UtcNow.AddMinutes(_jwtModel.Value.ExpireMinutes),
            signingCredentials: signingCredentials
        );
        return securityToken;
    }

    private SigningCredentials generateSigningCredentials()
    {
        SymmetricSecurityKey symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtModel.Value.Key));
        SigningCredentials signingCredentials = new
        (
            symmetricSecurityKey,
            SecurityAlgorithms.HmacSha256
        );
        return signingCredentials;
    }

    private IEnumerable<Claim> generateClaims(User user, string role)
    {
        IEnumerable<Claim> claims = new List<Claim>
        {
            new Claim("UserName", user.UserName!),
            new Claim("Id", user.Id),
            new Claim("Email", user.Email!),
            new Claim("Role", role)
        };
        return claims;
    }

    public async Task<RefreshToken> GenerateRefreshToken(User user)
    {
        string refreshToken = GenerateRefreshTokenValue(user.Id);
        RefreshToken refreshTokenModel = new RefreshToken
        {
            Token = refreshToken,
            Expires = DateTime.UtcNow.AddMinutes(_jwtModel.Value.RefreshExpireMinutes),
        };
        if (user.RefreshToken.Any(i => i.IsActive))
        {
            user.RefreshToken
                .Where(i => i.IsActive)
                .ToList()
                .ForEach(i => i.Revoked = DateTime.UtcNow);
        }
        user.RefreshToken.Add(refreshTokenModel);
        await _userManager.UpdateAsync(user);
        CookieOptions cookieOptions = new CookieOptions
        {
            HttpOnly = true,
            Expires = refreshTokenModel.Expires
        };
        _httpContextAccessor.HttpContext!.Response.Cookies.Append("refreshToken", refreshTokenModel.Token, cookieOptions);
        return refreshTokenModel;
    }

    private string GenerateRefreshTokenValue(string id)
    {
        return $"Krist_{id}_{DateTime.UtcNow.ToString("yyyy-MM-dd")}_{DateTime.UtcNow.ToString("HH:mm:ss")}";
    }
}
