namespace Ecommerce.Infrastucture.Specification.ModelsSpecifications.ProductSpecification;

public sealed class ProductGetByIdSpecification : Specification<Product, Product>
{
    public ProductGetByIdSpecification(string Id) : base(i => i.Id == Id)
    {
        AddInclude(i =>
        i.Include(p => p.Category)
        .Include(i => i.Brand)
        .Include(i => i.Images)
        .Include(i => i.Reviews)
        .Include(i => i.ProductAttributes).ThenInclude(i => i.Attributes)
        .Include(i => i.CareInstructions)
        .Include(i => i.Features)
        .Include(i => i.Tags)
        .Include(i => i.Discount)
        .Include(i => i.ProductVariant)
        );
    }
}
