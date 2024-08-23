using Ecommerce.Application.Feature.OfferFeature.Queries.Models;

namespace Ecommerce.API.Controllers.V1;

[ApiVersion("1.0")]
public class OfferController : ApplicationBaseController
{
    [HttpGet(OfferRoutes.GetAll)]
    public async Task<IActionResult> GetAllAsync(int PageNumber, int PageSize) =>
        BaseResponse(await _mediator.Send(new OfferGetAllModel(PageNumber, PageSize)));
}
