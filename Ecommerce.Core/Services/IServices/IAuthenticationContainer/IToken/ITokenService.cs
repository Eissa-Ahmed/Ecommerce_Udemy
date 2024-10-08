﻿namespace Ecommerce.Application.Services.IServices.IAuthenticationContainer.IToken;

public interface ITokenService
{
    public string GenerateToken(User user, string role);
    public Task<RefreshToken> GenerateRefreshToken(User user);
}
