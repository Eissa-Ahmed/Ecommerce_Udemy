﻿using Ecommerce.Application.Feature.CategoryFeature.Commands.Models;

namespace Ecommerce.API.Controllers.V1;

[ApiVersion("1.0")]
public class CategoryController : ApplicationBaseController
{
    [HttpGet(CategoryRoutes.GetAll)]
    public async Task<IActionResult> GetAllAsync()
    {
        var result = await _mediator.Send(new CategoryGetAllModel());
        return BaseResponse(result);
    }
    [HttpGet(CategoryRoutes.GetById)]
    public async Task<IActionResult> GetByIdAsync(string Name)
    {
        var result = await _mediator.Send(new CategoryGetByIdModel(Name));
        return BaseResponse(result);
    }
    [HttpPost(CategoryRoutes.Create)]
    public async Task<IActionResult> CreateAsync([FromBody] CategoryCreateModel model)
    {
        var result = await _mediator.Send(model);
        return BaseResponse(result);
    }
    [HttpDelete(CategoryRoutes.Delete)]
    public async Task<IActionResult> DeleteAsync(string Name)
    {
        var result = await _mediator.Send(new CategoryDeleteModel(Name));
        return BaseResponse(result);
    }
}