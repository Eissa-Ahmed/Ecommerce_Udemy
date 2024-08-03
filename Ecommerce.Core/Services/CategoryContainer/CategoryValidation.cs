namespace Ecommerce.Application.Services.CategoryContainer;

public sealed class CategoryValidation : ICategoryValidation
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ICategoryServices _categoryServices;

    public CategoryValidation(IUnitOfWork unitOfWork, ICategoryServices categoryServices)
    {
        _unitOfWork = unitOfWork;
        _categoryServices = categoryServices;
    }

    private async Task<bool> CategoryHasProduct(string name)
    {
        return await _unitOfWork.CategoryRepository.CategoryHasProduct(name);
    }

    public async Task<bool> CategoryHasSubCategory_Or_Product(string name)
    {
        Category? category = await _categoryServices.GetByIdAsync(name);
        bool categoryIsHas = await CategoryHasProduct(category.Name);
        if (categoryIsHas) return categoryIsHas;

        foreach (var subCategory in category.SubCategories)
        {
            bool isHas = await CategoryHasProduct(subCategory.Name);
            if (isHas) return isHas;
        }
        return false;
    }

    public async Task<bool> CategoryIsExist(string name)
    {
        ISpecification<Category> specification = new CategorySpecification(i => i.Name == name);
        return await _unitOfWork.CategoryRepository.GetByIdAsync(specification) != null;
    }
}
