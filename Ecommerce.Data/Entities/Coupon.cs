namespace Ecommerce.Domain.Entities;

public sealed class Coupon
{
    public Coupon()
    {
        Id = Guid.NewGuid().ToString();
        Orders = new List<Order>();
    }
    public string Id { get; set; }
    public string Code { get; set; } = null!;
    public decimal DiscountPercentage { get; set; }
    public DateTime ValidFrom { get; set; }
    public DateTime ValidTo { get; set; }
    public int UsageLimit { get; set; }
    public bool IsValid => DateTime.UtcNow >= ValidFrom && DateTime.UtcNow <= ValidTo;

    public ICollection<Order> Orders { get; set; }
}