namespace Ecommerce.Application.Services.RequestContainer;

public sealed class RequestService : IRequestService
{
    private readonly IHttpContextAccessor _contextAccessor;
    public RequestService(IHttpContextAccessor contextAccessor)
    {
        _contextAccessor = contextAccessor;
    }
    public string GetUserIdFromToken()
    {
        string token = GetTokenFromHeader().Split(" ")[1];
        JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
        JwtSecurityToken jsonToken = handler.ReadJwtToken(token);
        return jsonToken.Claims.First(claim => claim.Type == "Id").Value;

    }
    private string GetTokenFromHeader()
    {
        _contextAccessor!.HttpContext!.Request.Headers.TryGetValue("Authorization", out var token);
        return token!;
    }
}
