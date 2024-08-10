namespace Ecommerce.API.Controllers.V1;

[ApiVersion("1.0")]
public class ProductsController : ApplicationBaseController
{
    [HttpPost(ProductRoutes.Create)]
    public async Task<IActionResult> CreateAsync([FromForm] ProductCreateModel model)
    {
        return BaseResponse(await _mediator.Send(model));
    }

    [HttpGet(ProductRoutes.GetAll)]
    public async Task<IActionResult> GetAllAsync(int PageNumber, int PageSize, string? CategoryId = null, string? BrandId = null, string? SortByPrice = null, string? Search = null)
    {
        return BaseResponse(await _mediator.Send(new ProductGetAllModel(PageNumber, PageSize, CategoryId, BrandId, SortByPrice, Search)));
    }

    [HttpGet(ProductRoutes.GetById)]
    public async Task<IActionResult> GetByIdAsync(string Id)
    {
        return BaseResponse(await _mediator.Send(new ProductGetByIdModel(Id)));
        //return NotFound();
    }

}
