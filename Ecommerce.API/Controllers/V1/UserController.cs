namespace Ecommerce.API.Controllers.V1;

[ApiVersion("1.0")]

public class UserController : ApplicationBaseController
{
    [HttpGet(UserRoutes.GetById)]
    public async Task<IActionResult> GetById(string Id) => BaseResponse(await _mediator.Send(new UserGetByIdModel(Id)));

    [HttpPost(UserRoutes.UserSubscription)]
    public async Task<IActionResult> UserSubscription(string Email) => BaseResponse(await _mediator.Send(new UserSubscriptionModel(Email)));
}
