namespace Ecommerce.Application.Services.CategoryContainer;

public sealed class CategoryServices : ICategoryServices
{
    private readonly IUnitOfWork _unitOfWork;

    public CategoryServices(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<Category> CreateAsync(Category category)
    {
        Category result = await _unitOfWork.CategoryRepository.CreateAsync(category);
        /*foreach (var subCategory in result.SubCategories)
        {
            subCategory.cat = result.Name;
        }*/
        return result;
    }

    public async Task DeleteAsync(string name)
    {
        Category? category = await GetByIdAsync(name);
        await _unitOfWork.CategoryRepository.DeleteAsync(category!);
    }

    public async Task<IReadOnlyList<Category>> GetAllAsync()
    {
        ISpecification<Category> specification = new CategorySpecification();
        IReadOnlyList<Category> categories = await _unitOfWork.CategoryRepository.GetAllAsync(specification);
        return Helper.GetCategories(categories.ToList());
    }

    public async Task<Category> GetByIdAsync(string name)
    {
        ISpecification<Category> specificationCategory = new CategorySpecification(i => i.Name == name);
        ISpecification<Category> specificationCategories = new CategorySpecification();
        Category? category = await _unitOfWork.CategoryRepository.GetByIdAsync(specificationCategory);
        IReadOnlyList<Category> categories = await _unitOfWork.CategoryRepository.GetAllAsync(specificationCategories);
        return Helper.GetCategory(category!, categories.ToList());
    }

    public async Task<Category> UpdateAsync(Category category)
    {
        await _unitOfWork.CategoryRepository.UpdateAsync(category);
        return category;
    }
}
