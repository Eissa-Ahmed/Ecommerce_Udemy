namespace Ecommerce.Application.Services.IServices.IOfferContainer;
public interface IOfferService
{
    Task<Discount> CreateAsync(Discount discount);
    Task<Discount> UpdateAsync(Discount discount);
    Task<Pagination<Discount>> GetAllAsync(int pageNumber, int pageSize);
    Task DeleteAsync(string id);
}
