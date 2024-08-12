/*namespace Ecommerce.Application.Services.AuthenticationContainer.Token;

public sealed class TokenService : ITokenService
{
    private readonly JWTModel _jwtModel;
    public TokenService(JWTModel jwtModel)
    {
        _jwtModel = jwtModel;
    }
    public string GenerateToken(ApplicationUser user)
    {
        SecurityToken securityToken = generateSecurityToken(user);
        return new JwtSecurityTokenHandler().WriteToken(securityToken);
    }

    private SecurityToken generateSecurityToken(ApplicationUser user)
    {
        IEnumerable<Claim> claims = generateClaims(user);
        SigningCredentials signingCredentials = generateSigningCredentials();
        SecurityToken securityToken = new JwtSecurityToken
        (
            issuer: _jwtModel.Issuer,
            audience: _jwtModel.Audience,
            claims: claims,
            expires: DateTime.UtcNow.AddMinutes(_jwtModel.ExpireMinutes),
            signingCredentials: signingCredentials
        );
        return securityToken;
    }

    private SigningCredentials generateSigningCredentials()
    {
        SymmetricSecurityKey symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtModel.Key));
        SigningCredentials signingCredentials = new
        (
            symmetricSecurityKey,
            SecurityAlgorithms.HmacSha256
        );
        return signingCredentials;
    }

    private IEnumerable<Claim> generateClaims(ApplicationUser user)
    {
        IEnumerable<Claim> claims = new List<Claim>
        {
            new Claim("UserName", user.UserName!),
            new Claim("Id", user.Id),
            new Claim("Email", user.Email!)
        };
        return claims;
    }
}
*/