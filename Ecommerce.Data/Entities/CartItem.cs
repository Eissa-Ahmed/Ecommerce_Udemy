namespace Ecommerce.Domain.Entities;

public sealed class CartItem
{
    public string Id { get; set; } = null!;
    public string ProductId { get; set; } = null!;
    public int Quantity { get; set; }
    public string CartId { get; set; } = null!;


}