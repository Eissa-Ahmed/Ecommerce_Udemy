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

    public async Task<bool> CategoryHasProduct(string Id)
    {
        return await _unitOfWork.CategoryRepository.CategoryHasProduct(Id);
    }

    public async Task<bool> CategoryHasSubCategory_Or_Product(string Id)
    {
        Category? category = await _categoryServices.GetByIdAsync(Id);
        if (category is null) return false;

        bool categoryIsHas = await CategoryHasProduct(category.Id);
        if (categoryIsHas) return categoryIsHas;

        foreach (var subCategory in category.SubCategories)
        {
            bool isHas = await CategoryHasProduct(subCategory.Id);
            if (isHas) return isHas;
        }
        return false;
    }

    public async Task<bool> CategoryIsExist_ById(string Id)
    {
        return await _unitOfWork.CategoryRepository.IsExist(i => i.Id == Id);
    }
    public async Task<bool> CategoryIsExist_ByName(string name)
    {
        return await _unitOfWork.CategoryRepository.IsExist(i => i.Name == name);
    }

    public async Task<bool> CategoryHaveSubCategoriesAsync(string Id)
    {
        return await _unitOfWork.CategoryRepository.CategoryHaveSubCategoriesAsync(Id);
    }
}
