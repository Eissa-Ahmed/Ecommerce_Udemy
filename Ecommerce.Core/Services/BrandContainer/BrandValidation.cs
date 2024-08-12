namespace Ecommerce.Application.Services.BrandContainer;

public sealed class BrandValidation : IBrandValidation
{
    private readonly IUnitOfWork _unitOfWork;

    public BrandValidation(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<bool> BrandIsExist(string brandId)
    {
        /*List<Expression<Func<Brand, bool>>> criteria = new List<Expression<Func<Brand, bool>>>()
        {
            brand => brand.Id == brandId
        };
        BrandSpecification brandSpecification = new BrandSpecification(criteria);
        Brand? brand = await _unitOfWork.BrandRepository.GetByIdAsync(brandSpecification);
        return brand != null;*/
        throw new NotImplementedException();
    }
}
