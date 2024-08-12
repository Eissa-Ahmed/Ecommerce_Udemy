namespace Ecommerce.Application.Services.ProductContainer;

public sealed class ProductValidation : IProductValidation
{
    private readonly IUnitOfWork _unitOfWork;
    public ProductValidation(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    public async Task<bool> ProductIsExist(string Id)
    {
        return await _unitOfWork.ProductRepository.IsExist(p => p.Id == Id);
    }
}
