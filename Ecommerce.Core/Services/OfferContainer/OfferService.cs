namespace Ecommerce.Application.Services.OfferContainer;

public sealed class OfferService : IOfferService
{
    private readonly IUnitOfWork _unitOfWork;

    public OfferService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<Discount> CreateAsync(Discount discount)
    {
        await _unitOfWork.DiscountRepository.CreateAsync(discount);
        return discount;
    }

    public async Task DeleteAsync(string id)
    {
        await _unitOfWork.DiscountRepository.DeleteAsync(id);
    }

    public async Task<Pagination<Discount>> GetAllAsync(int pageNumber, int pageSize)
    {
        DiscountGetAllSpecification discountGetAllSpecification = new(pageNumber, pageSize);
        IReadOnlyList<Discount> discounts = await _unitOfWork.DiscountRepository.GetAllAsync(discountGetAllSpecification);
        int totalCount = await _unitOfWork.DiscountRepository.CountAsync();

        return new Pagination<Discount>(discounts.ToList(), pageNumber, pageSize, totalCount);
    }

    public Task<Discount> UpdateAsync(Discount discount)
    {
        return _unitOfWork.DiscountRepository.UpdateAsync(discount);
    }
}
