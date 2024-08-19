namespace Ecommerce.Application.Services.IServices.IDiscountContainer;

public interface IDiscountValidation
{
    Task<bool> DiscountIsExist(string discountId);
}
