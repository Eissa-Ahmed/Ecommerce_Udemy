using Ecommerce.Infrastucture.ApplicationHelper;
using Ecommerce.Infrastucture.Context;

namespace Ecommerce.Application.Services.CategoryContainer;

public sealed class CategoryServices : ICategoryServices
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ApplicationDbContext _dbContext;

    public CategoryServices(IUnitOfWork unitOfWork, ApplicationDbContext dbContext)
    {
        _unitOfWork = unitOfWork;
        _dbContext = dbContext;
    }

    public async Task<Category> CreateAsync(Category category)
    {
        return await _unitOfWork.CategoryRepository.CreateAsync(category);
    }

    public async Task DeleteAsync(string name)
    {
        ISpecification<Category> specification = new CategorySpecification(i => i.Name == name);
        Category? category = await _unitOfWork.CategoryRepository.GetByIdAsync(specification);
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
