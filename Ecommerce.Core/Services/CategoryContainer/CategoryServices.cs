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
        return result;
    }

    public async Task DeleteAsync(string Id)
    {
        Category? category = await GetByIdAsync(Id);
        await _unitOfWork.CategoryRepository.DeleteAsync(category!);
    }

    public async Task<IReadOnlyList<Category>> GetAllAsync()
    {
        ISpecification<Category> specification = new CategorySpecification();
        IReadOnlyList<Category> categories = await _unitOfWork.CategoryRepository.GetAllAsync(specification);
        return Helper.GetCategories(categories.ToList());
    }

    public async Task<Category> GetByIdAsync(string Id)
    {
        ISpecification<Category> specificationCategory = new CategorySpecification(i => i.Id == Id);
        ISpecification<Category> specificationCategories = new CategorySpecification();
        Category? category = await _unitOfWork.CategoryRepository.GetByIdAsync(specificationCategory);
        IReadOnlyList<Category> categories = await _unitOfWork.CategoryRepository.GetAllAsync(specificationCategories);
        return Helper.GetCategory(category!, categories.ToList());
    }

    public async Task<Category> UpdateAsync(string name, string newName)
    {
        ISpecification<Category> specification = new CategorySpecification(i => i.Name == name);
        //Category? category = await _unitOfWork.CategoryRepository.GetByIdAsync(specification);
        Category? category = await GetByIdAsync(name);
        category!.Name = newName;
        await _unitOfWork.CategoryRepository.UpdateAsync(category!);
        /*Category? category = await _context.Categories.FirstOrDefaultAsync(i => i.Name == name);
        category!.Name = newName;
        _context.Categories.Update(category);
        await _context.SaveChangesAsync();*/
        return category;

    }
}
