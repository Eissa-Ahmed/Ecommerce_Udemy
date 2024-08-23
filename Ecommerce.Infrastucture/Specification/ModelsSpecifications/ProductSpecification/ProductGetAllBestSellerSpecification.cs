namespace Ecommerce.Infrastucture.Specification.ModelsSpecifications.ProductSpecification;

public sealed class ProductGetAllBestSellerSpecification : Specification<Product, Product>
{
    public ProductGetAllBestSellerSpecification(int pageNumber, int pageSize)
    {
        AddInclude(i => i.Include(p => p.ProductVariant));
        AddOrderByDescending(i => i.OrderItem.Count);
        ApplyPaging(pageNumber, pageSize);
    }
}