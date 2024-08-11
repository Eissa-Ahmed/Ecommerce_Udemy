namespace Ecommerce.Domain.Entities;

public sealed class Order
{
    public Order()
    {
        OrderDate = DateTime.UtcNow;
        OrderItems = new List<OrderItem>();
        OrderCoupons = new List<OrderCoupon>();
        OrderShippings = new List<OrderShipping>();
    }
    public string Id { get; set; } = null!;
    public string UserId { get; set; } = null!;
    public User User { get; set; } = null!;
    public DateTime OrderDate { get; set; }
    public decimal ShippingAmount { get; set; }
    public decimal TotalAmount { get; set; }
    public OrderStatus Status { get; set; }
    public string PaymentId { get; set; } = null!;
    public Payment Payment { get; set; } = null!;
    public ICollection<OrderItem> OrderItems { get; set; }
    public ICollection<OrderCoupon> OrderCoupons { get; set; }
    public ICollection<OrderShipping> OrderShippings { get; set; }
}
