namespace Ecommerce.Domain.Entities;

public sealed class ProductDiscount
{
    public ProductDiscount()
    {
        Id = Guid.NewGuid().ToString();
    }
    public string Id { get; set; }
    public string ProductId { get; set; } = null!;
    public string DiscountId { get; set; } = null!;

    public Product Product { get; set; } = null!;
    public Discount Discount { get; set; } = null!;
}
