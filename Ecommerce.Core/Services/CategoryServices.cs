namespace Ecommerce.Application.Services;

public sealed class CategoryServices : ICategoryServices
{
    private readonly IUnitOfWork _unitOfWork;

    public CategoryServices(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IReadOnlyList<Category>> GetAllAsync()
    {
        ISpecification<Category> specification = new CategorySpecification();
        return await _unitOfWork.CategoryRepository.GetAllAsync(specification);
    }
}
