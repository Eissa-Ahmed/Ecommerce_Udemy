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
        ISpecification<Category> specification = new CategorySpecification(name);
        Category? category = await _unitOfWork.CategoryRepository.GetByIdAsync(specification);
        await _unitOfWork.CategoryRepository.DeleteAsync(category!);
    }

    public async Task<IReadOnlyList<Category>> GetAllAsync()
    {
        ISpecification<Category> specification = new CategorySpecification();
        return await _unitOfWork.CategoryRepository.GetAllAsync(specification);
        /* return await _dbContext.Categories.Where(i => i.ParentCategoryName == null)
             .Include(i => i.SubCategories)
             .ThenInclude(i => i.SubCategories)
             .ThenInclude(i => i.SubCategories)
             .ToListAsync();*/
    }

    public async Task<Category> GetByIdAsync(string name)
    {
        //ISpecification<Category> specification = new CategorySpecification(name);
        //Category? category = await _unitOfWork.CategoryRepository.GetByIdAsync(specification);
        Category? category = await _unitOfWork.CategoryRepository.GetByIdAsync2(name);
        return category!;
    }

    public async Task<Category> UpdateAsync(Category category)
    {
        await _unitOfWork.CategoryRepository.UpdateAsync(category);
        return category;
    }
}
