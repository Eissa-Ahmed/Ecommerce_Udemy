namespace Ecommerce.Application.Services.IServices.IOfferContainer;

public interface IOfferValidation
{
    Task<bool> DiscountIsExist(string id);
}
