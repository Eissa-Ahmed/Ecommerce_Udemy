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
    public async Task<IActionResult> GetByIdAsync(string Id)
    {
        var result = await _mediator.Send(new CategoryGetByIdModel(Id));
        return BaseResponse(result);
    }
    [HttpPost(CategoryRoutes.Create)]
    public async Task<IActionResult> CreateAsync([FromBody] CategoryCreateModel model)
    {
        var result = await _mediator.Send(model);
        return BaseResponse(result);
    }
    [HttpDelete(CategoryRoutes.Delete)]
    public async Task<IActionResult> DeleteAsync(string Id)
    {
        var result = await _mediator.Send(new CategoryDeleteModel(Id));
        return BaseResponse(result);
    }
    [HttpPut(CategoryRoutes.Update)]
    public async Task<IActionResult> UpdateAsync(string Id, string Name)
    {
        var result = await _mediator.Send(new CategoryUpdateNameModel(Id, Name));
        return BaseResponse(result);
    }
    [HttpPut(CategoryRoutes.AddSubCategory)]
    public async Task<IActionResult> AddSubCategoryToCategoryAsync(string IdParent, string SubCategoryName)
    {
        var result = await _mediator.Send(new CategoryAddSubCategoryModel(IdParent, SubCategoryName));
        return BaseResponse(result);
    }
}
