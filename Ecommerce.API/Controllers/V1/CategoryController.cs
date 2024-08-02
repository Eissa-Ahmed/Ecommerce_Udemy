namespace Ecommerce.API.Controllers.V1;

[ApiVersion("1.0")]
public class CategoryController : ApplicationBaseController
{
    [HttpGet(CategoryRoutes.GetAll)]
    public async Task<IActionResult> GetAllAsync(int count)
    {
        var result = await _mediator.Send(new CategoryGetAllModel(count));
        return BaseResponse(result);
    }
}
