namespace Ecommerce.Application.Services.AuthenticationContainer.Token;

public sealed class TokenService : ITokenService
{
    private readonly IOptions<JWTModel> _jwtModel;
    public TokenService(IOptions<JWTModel> jwtModel)
    {
        _jwtModel = jwtModel;
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
}
