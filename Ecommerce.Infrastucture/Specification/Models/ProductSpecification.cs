namespace Ecommerce.Infrastucture.Specification.Models;

public sealed class ProductSpecification : Specification<Product>
{
    public ProductSpecification(int skip, int take) : base(skip, take) { }
    public ProductSpecification(string id) : base(i => i.Id == id) { }
}
