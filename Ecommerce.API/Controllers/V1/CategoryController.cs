namespace Ecommerce.API.Controllers.V1;

[ApiVersion("1.0")]
public class CategoryController : ApplicationBaseController
{
    [HttpGet(CategoryRoutes.GetAll)]
    public async Task<IActionResult> GetAllAsync() => BaseResponse(await _mediator.Send(new CategoryGetAllModel()));


    [HttpGet(CategoryRoutes.GetById)]
    public async Task<IActionResult> GetByIdAsync(string Id) => BaseResponse(await _mediator.Send(new CategoryGetByIdModel(Id)));

    [HttpPost(CategoryRoutes.Create)]
    public async Task<IActionResult> CreateAsync([FromBody] CategoryCreateModel model) => BaseResponse(await _mediator.Send(model));

    [HttpDelete(CategoryRoutes.Delete)]
    public async Task<IActionResult> DeleteAsync(string Id) => BaseResponse(await _mediator.Send(new CategoryDeleteModel(Id)));

    [HttpPut(CategoryRoutes.Update)]
    public async Task<IActionResult> UpdateAsync(string Id, string Name) => BaseResponse(await _mediator.Send(new CategoryUpdateNameModel(Id, Name)));
}
