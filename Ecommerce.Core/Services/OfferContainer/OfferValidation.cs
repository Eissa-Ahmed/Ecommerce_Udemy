namespace Ecommerce.Application.Services.OfferContainer;

public sealed class OfferValidation : IOfferValidation
{
    private readonly IUnitOfWork _unitOfWork;

    public OfferValidation(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<bool> DiscountIsExist(string id)
    {
        return await _unitOfWork.DiscountRepository.IsExist(i => i.Id == id);
    }
}
