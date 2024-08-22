namespace Ecommerce.Infrastucture.Specification.ModelsSpecifications.ProductSpecification;

public sealed class ProductGetAllBestSellerSpecification : Specification<Product>
{
    public ProductGetAllBestSellerSpecification(int pageNumber, int pageSize)
    {
        AddOrderByDescending(i => i.OrderItem.Count);
        ApplyPaging(pageNumber, pageSize);
    }
}