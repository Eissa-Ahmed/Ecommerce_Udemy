
namespace Ecommerce.Application.Services.CategoryContainer;

public sealed class CategoryValidation : ICategoryValidation
{
    private readonly IUnitOfWork _unitOfWork;

    public CategoryValidation(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<bool> CategoryIsExist(string name)
    {
        ISpecification<Category> specification = new CategorySpecification(name);
        return await _unitOfWork.CategoryRepository.GetByIdAsync(specification) != null;
    }
}
