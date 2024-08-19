namespace Ecommerce.Application.Services.DiscountContainer;

public sealed class DiscountValidation : IDiscountValidation
{
    private readonly IUnitOfWork _unitOfWork;

    public DiscountValidation(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<bool> DiscountIsExist(string discountId)
    {
        return await _unitOfWork.DiscountRepository.IsExist(i => i.Id == discountId);
    }
}
