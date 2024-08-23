namespace Ecommerce.API.Controllers.V1;

[ApiVersion("1.0")]
public class ProductsController : ApplicationBaseController
{
    [HttpPost(ProductRoutes.Create)]
    public async Task<IActionResult> CreateAsync([FromForm] ProductCreateModel model)
        => BaseResponse(await _mediator.Send(model));

    [HttpPost(ProductRoutes.GetAll)]
    public async Task<IActionResult> GetAllAsync([FromBody] ProductGetAllModel model)
         => BaseResponse(await _mediator.Send(model));

    [HttpGet(ProductRoutes.BestSeller)]
    public async Task<IActionResult> BestSeller(int PageNumber, int PageSize)
         => BaseResponse(await _mediator.Send(new ProductGetAllBestSellerModel(PageNumber, PageSize)));

    [HttpGet(ProductRoutes.GetById)]
    public async Task<IActionResult> GetByIdAsync(string Id)
        => BaseResponse(await _mediator.Send(new ProductGetByIdModel(Id)));

}
