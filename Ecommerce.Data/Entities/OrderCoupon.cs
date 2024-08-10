namespace Ecommerce.Domain.Entities;

public sealed class OrderCoupon
{
    public OrderCoupon()
    {
        Id = Guid.NewGuid().ToString();
    }
    public string Id { get; set; }
    public string OrderId { get; set; } = null!;
    public string CouponId { get; set; } = null!;

    public Order Order { get; set; } = null!;
    public Coupon Coupon { get; set; } = null!;
}
