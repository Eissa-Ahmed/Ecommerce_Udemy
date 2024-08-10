namespace Ecommerce.Domain.Entities;

public sealed class Discount
{
    public Discount()
    {
        Id = Guid.NewGuid().ToString();
        ProductDiscounts = new List<ProductDiscount>();
    }
    public string Id { get; set; }
    public string DiscountName { get; set; } = null!;
    public decimal DiscountPercentage { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    public ICollection<ProductDiscount> ProductDiscounts { get; set; } // علاقة الخصم بخصومات المنتجات
}