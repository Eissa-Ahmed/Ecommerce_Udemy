namespace Ecommerce.Application.Services.CategoryContainer;

public sealed class CategoryServices : ICategoryServices
{
    private readonly IUnitOfWork _unitOfWork;

    public CategoryServices(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<Category> AddSubCategoryInCategoryAsync(Category category)
    {
        //Category parentCategory = await GetByIdAsync(idParentCategory);
        //parentCategory.SubCategories.Add(category);
        Category result = await _unitOfWork.CategoryRepository.CreateAsync(category);
        return result;
    }

    public async Task<Category> CreateAsync(Category category)
    {
        Category result = await _unitOfWork.CategoryRepository.CreateAsync(category);
        return result;
    }

    public async Task DeleteAsync(string id)
    {
        Category? category = await GetByIdAsync(id);
        await _unitOfWork.CategoryRepository.DeleteAsync(category!);
    }

    public async Task<IReadOnlyList<Category>> GetAllAsync()
    {
        ISpecification<Category> specification = new CategorySpecification();
        IReadOnlyList<Category> categories = await _unitOfWork.CategoryRepository.GetAllAsync(specification);
        return Helper.GetCategories(categories.ToList());
    }

    public async Task<Category> GetByIdAsync(string id)
    {
        ISpecification<Category> specificationCategory = new CategorySpecification(i => i.Id == id);
        ISpecification<Category> specificationCategories = new CategorySpecification();
        Category? category = await _unitOfWork.CategoryRepository.GetByIdAsync(specificationCategory);
        IReadOnlyList<Category> categories = await _unitOfWork.CategoryRepository.GetAllAsync(specificationCategories);
        return Helper.GetCategory(category!, categories.ToList());
    }

    public async Task<Category> UpdateNameAsync(string id, string name)
    {
        ISpecification<Category> specificationCategory = new CategorySpecification(i => i.Id == id, applyTracking: true);
        Category? category = await _unitOfWork.CategoryRepository.GetByIdAsync(specificationCategory);
        category!.Name = name;
        await _unitOfWork.SaveChangesAsync();
        return await GetByIdAsync(id);
    }
}
