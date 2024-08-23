namespace Ecommerce.API.Controllers.V1;

[ApiVersion("1.0")]
public class ApplicationSettingsController : ApplicationBaseController
{
    [HttpGet(ApplicationSettingRoutes.Get)]
    public async Task<IActionResult> GetAsync() => BaseResponse(await _mediator.Send(new ApplicationSettingsGetModel()));
}
