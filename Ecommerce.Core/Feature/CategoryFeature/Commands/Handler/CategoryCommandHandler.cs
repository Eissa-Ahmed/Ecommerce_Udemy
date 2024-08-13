namespace Ecommerce.Application.Feature.CategoryFeature.Commands.Handler;

public sealed class CategoryCommandHandler : ResponseHandler,
    IRequestHandler<CategoryCreateModel, ApplicationResponse<CategoryCreateResult>>,
    IRequestHandler<CategoryUpdateNameModel, ApplicationResponse<CategoryUpdateResult>>,
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
        Category category = _mapper.Map<Category>(request);
        category.ParentCategoryId = request.ParentId;

        return Created(_mapper.Map<CategoryCreateResult>(await _categoryService.CreateAsync(category)));
    }

    public async Task<ApplicationResponse<string>> Handle(CategoryDeleteModel request, CancellationToken cancellationToken)
    {
        await _categoryService.DeleteAsync(request.Id);
        return Success();
    }

    public async Task<ApplicationResponse<CategoryUpdateResult>> Handle(CategoryUpdateNameModel request, CancellationToken cancellationToken)
    {
        Category result = await _categoryService.UpdateNameAsync(request.Id, request.Name);
        return Success(_mapper.Map<CategoryUpdateResult>(result));
    }
}
