namespace Ecommerce.Application.Feature.CategoryFeature.Commands.Handler;

public sealed class CategoryCommandHandler : ResponseHandler,
    IRequestHandler<CategoryCreateModel, ApplicationResponse<CategoryCreateResult>>,
    IRequestHandler<CategoryUpdateModel, ApplicationResponse<CategoryUpdateResult>>,
    IRequestHandler<CategoryDeleteModel, ApplicationResponse<string>>
{
    private readonly ICategoryServices _categoryService;
    private readonly IMapper _mapper;

    public CategoryCommandHandler(ICategoryServices categoryService, IMapper mapper)
    {
        _categoryService = categoryService;
        _mapper = mapper;
    }

    public async Task<ApplicationResponse<CategoryCreateResult>> Handle(CategoryCreateModel request, CancellationToken cancellationToken)
    {
        return Created(_mapper.Map<CategoryCreateResult>(await _categoryService.CreateAsync(_mapper.Map<Category>(request))));
    }

    public async Task<ApplicationResponse<string>> Handle(CategoryDeleteModel request, CancellationToken cancellationToken)
    {
        await _categoryService.DeleteAsync(request.Id);
        return Success();
    }

    public async Task<ApplicationResponse<CategoryUpdateResult>> Handle(CategoryUpdateModel request, CancellationToken cancellationToken)
    {
        Category result = await _categoryService.UpdateAsync(request.CategoryName, request.NewCategoryName);
        return Success(_mapper.Map<CategoryUpdateResult>(result));
    }
}
