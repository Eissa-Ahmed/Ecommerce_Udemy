namespace Ecommerce.Application.Services.IServices.IProductContainer;

public interface IProductHelper
{
    public List<Product> SortedProductsByPrice(List<Product> products, string sortBy);
}
