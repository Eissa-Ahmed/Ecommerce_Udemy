namespace Ecommerce.Application.Services.ProductContainer;

public sealed class ProductHelper : IProductHelper
{
    public List<Product> SortedProductsByPrice(List<Product> products, string sortBy)
    {

        if (sortBy == "ASC")
            products = products.OrderBy(i => i.Price).ToList();
        else
            products = products.OrderByDescending(i => i.Price).ToList();

        return products;
    }
}
