namespace Ecommerce.Domain.Entities;

public sealed class Order
{
    public Order()
    {
        Id = Guid.NewGuid().ToString();
        OrderDate = DateTime.UtcNow;
        OrderItems = new List<OrderItem>();
    }
    public string Id { get; set; }
    public string UserId { get; set; } = null!;
    public User User { get; set; } = null!;
    public DateTime OrderDate { get; set; }
    public decimal ShippingCost { get; set; }
    public decimal TotalAmount { get; set; }
    public OrderStatus Status { get; set; }
    public string PaymentId { get; set; } = null!;
    public Payment Payment { get; set; } = null!;
    public string? CouponId { get; set; } = null;
    public Coupon? Coupon { get; set; } = null;
    public ICollection<OrderItem> OrderItems { get; set; }
}
