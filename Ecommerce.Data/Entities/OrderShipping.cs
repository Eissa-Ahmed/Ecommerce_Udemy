namespace Ecommerce.Domain.Entities;

public sealed class OrderShipping
{
    public OrderShipping()
    {
        Id = Guid.NewGuid().ToString();
        ShippedDate = DateTime.UtcNow;
    }
    public string Id { get; set; }
    public string OrderId { get; set; } = null!;
    public string ShippingMethodId { get; set; } = null!;
    public string TrackingNumber { get; set; } = null!;
    public DateTime? ShippedDate { get; set; }
    public DateTime? DeliveryDate { get; set; }

    public Order Order { get; set; } = null!;
    public ShippingMethods ShippingMethod { get; set; } = null!;
}
