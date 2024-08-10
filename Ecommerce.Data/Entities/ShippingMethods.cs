namespace Ecommerce.Domain.Entities;

public sealed class ShippingMethods
{
    public ShippingMethods()
    {
        Id = Guid.NewGuid().ToString();
        OrderShippings = new List<OrderShipping>();
    }
    public string Id { get; set; }
    public string MethodName { get; set; } = null!;
    public decimal Cost { get; set; }  
    public string EstimatedDeliveryTime { get; set; } = null!;

    public ICollection<OrderShipping> OrderShippings { get; set; }
}