namespace Ecommerce.API.Controllers.V1;

[ApiVersion("1.0")]
public class AuthenticationController : ApplicationBaseController
{
    [HttpPost(AuthenticationRoutes.Login)]
    public async Task<IActionResult> Login([FromBody] AuthenticationLoginModel model) => BaseResponse(await _mediator.Send(model));

    [HttpPost(AuthenticationRoutes.Register)]
    public async Task<IActionResult> Register([FromBody] AuthenticationRegisterModel model) => BaseResponse(await _mediator.Send(model));

    [HttpGet(AuthenticationRoutes.RefreshToken)]
    public async Task<IActionResult> RefreshToken() => BaseResponse(await _mediator.Send(new AuthenticationRefreshTokenModel()));

    [HttpPut(AuthenticationRoutes.RevokeToken)]
    public async Task<IActionResult> RevokeToken() => BaseResponse(await _mediator.Send(new AuthenticationRevokeTokenModel()));
}
