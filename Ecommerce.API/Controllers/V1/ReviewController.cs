namespace Ecommerce.API.Controllers.V1;

[ApiVersion("1.0")]
public class ReviewController : ApplicationBaseController
{
    [HttpGet(ReviewRoutes.GetAll)]
    public async Task<IActionResult> GetAllAsync(int PageNumber, int PageSize)
        => BaseResponse(await _mediator.Send(new ReviewGetAllModel(PageNumber, PageSize)));
}
