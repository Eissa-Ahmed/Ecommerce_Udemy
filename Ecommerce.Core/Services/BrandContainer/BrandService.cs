
namespace Ecommerce.Application.Services.BrandContainer;

public sealed class BrandService : IBrandService
{
    private readonly IUnitOfWork _unitOfWork;

    public BrandService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<Brand> CreateAsync(Brand brand)
    {
        await _unitOfWork.BrandRepository.CreateAsync(brand);
        return brand;
    }

    public async Task DeleteAsync(string brandId)
    {
        bool hasProducts = BrandHasProducts(brandId);
        if (hasProducts)
            throw new Exception("Cannot Delete Brand, Has Products");

        await _unitOfWork.BrandRepository.DeleteAsync(brandId);
    }

    public Task<Pagination<Brand>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Brand> GetByIdAsync(string brandId)
    {
        throw new NotImplementedException();
    }

    public async Task<Brand> UpdateAsync(Brand brand)
    {
        await _unitOfWork.BrandRepository.UpdateAsync(brand);
        return brand;
    }

    private bool BrandHasProducts(string brandId)
    {
        return _unitOfWork.BrandRepository.hasProducts(brandId);
    }

}
