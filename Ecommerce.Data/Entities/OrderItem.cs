namespace Ecommerce.Domain.Entities;

public sealed class OrderItem
{
    public string Id { get; set; } = null!;
    public string OrderId { get; set; } = null!;
    public Order Order { get; set; } = null!;
    public string ProductId { get; set; } = null!;
    public Product Product { get; set; } = null!;
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; } // السعر الوحدة
}
