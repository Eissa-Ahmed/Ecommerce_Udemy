namespace Ecommerce.Domain.Entities;

public sealed class OrderItem
{
    public OrderItem()
    {
        Id = Guid.NewGuid().ToString();
    }
    public string Id { get; set; }
    public string OrderId { get; set; } = null!;
    public Order Order { get; set; } = null!;
    public string ProductId { get; set; } = null!;
    public Product Product { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string MainImage { get; set; } = null!;
    public int Quantity { get; set; }
    public decimal TotalPrice { get; set; }
}
