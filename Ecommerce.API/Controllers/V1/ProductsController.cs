﻿namespace Ecommerce.API.Controllers.V1;

[ApiVersion("1.0")]
public class ProductsController : ApplicationBaseController
{
    [HttpPost(ProductRoutes.Create)]
    public async Task<IActionResult> CreateAsync([FromForm] ProductCreateModel model)
    {
        return BaseResponse(await _mediator.Send(model));
    }

    [HttpGet(ProductRoutes.GetAll)]
    public async Task<IActionResult> GetAllAsync([FromBody] ProductGetAllModel model)
    {
        return BaseResponse(await _mediator.Send(model));
    }
}
