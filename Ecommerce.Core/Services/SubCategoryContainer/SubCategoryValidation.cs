namespace Ecommerce.Application.Services.SubCategoryContainer;

public sealed class SubCategoryValidation : ISubCategoryValidation
{
    private readonly IUnitOfWork _unitOfWork;

    public SubCategoryValidation(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<bool> SubCategoryIsExist(string subCategoryName)
    {
        ISpecification<SubCategory> specification = new SubCategorySpecification(subCategoryName);
        return await _unitOfWork.SubCategoryRepository.GetByIdAsync(specification) != null;
    }
}
