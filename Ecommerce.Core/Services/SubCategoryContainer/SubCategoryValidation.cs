namespace Ecommerce.Application.Services.SubCategoryContainer;

public sealed class SubCategoryValidation : ISubCategoryValidation
{
    private readonly ISubCategoryRepository _subCategoryRepository;

    public SubCategoryValidation(ISubCategoryRepository subCategoryRepository)
    {
        _subCategoryRepository = subCategoryRepository;
    }

    public async Task<bool> SubCategoryIsExist(string subCategoryName)
    {
        ISpecification<SubCategory> specification = new SubCategorySpecification(subCategoryName);
        return await _subCategoryRepository.GetByIdAsync(specification) != null;
    }
}
