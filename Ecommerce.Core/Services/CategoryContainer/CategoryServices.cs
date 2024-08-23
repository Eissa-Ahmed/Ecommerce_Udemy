namespace Ecommerce.Application.Services.CategoryContainer;

public sealed class CategoryServices : ICategoryServices
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ICategoryHelper _categoryHelper;

    public CategoryServices(IUnitOfWork unitOfWork, ICategoryHelper categoryHelper)
    {
        _unitOfWork = unitOfWork;
        _categoryHelper = categoryHelper;
    }
    public async Task<IReadOnlyList<Category>> GetAllAsync()
    {
        ISpecification<Category, Category> specification = new CategoryGetAllSpecification();
        IReadOnlyList<Category> categories = await _unitOfWork.CategoryRepository.GetAllAsync(specification);
        return _categoryHelper.GetCategories(categories.ToList());
    }
    public async Task<Category> GetByIdAsync(string id)
    {
        ISpecification<Category, Category> specificationGetAll = new CategoryGetAllSpecification();
        ISpecification<Category, Category> specificationGetById = new CategoryGetByIdSpecification(id);
        IReadOnlyList<Category> categories = await _unitOfWork.CategoryRepository.GetAllAsync(specificationGetAll);
        Category? category = await _unitOfWork.CategoryRepository.GetByIdAsync(specificationGetById);
        return _categoryHelper.GetCategory(category!, categories.ToList());
    }

    public async Task<Category> CreateAsync(Category category)
    {
        await _unitOfWork.CategoryRepository.CreateAsync(category);
        return await GetByIdAsync(category.Id);
    }

    public async Task DeleteAsync(string id)
    {
        await _unitOfWork.CategoryRepository.DeleteAsync(id);
    }


    public async Task<Category> UpdateNameAsync(string id, string name)
    {
        ISpecification<Category, Category> specificationGetById = new CategoryGetByIdSpecification(id);
        Category? category = await _unitOfWork.CategoryRepository.GetByIdAsync(specificationGetById);
        category!.Name = name;
        await _unitOfWork.CategoryRepository.UpdateAsync(category);
        return await GetByIdAsync(category.Id);
    }

}
