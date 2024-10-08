﻿namespace Ecommerce.Domain.Entities;

public sealed class CartItem
{
    public CartItem()
    {
        Id = Guid.NewGuid().ToString();
    }
    public string Id { get; set; }
    public string ProductId { get; set; } = null!;
    public int Quantity { get; set; }
    public string CartId { get; set; } = null!;
    public Cart Cart { get; set; } = null!;
    public Product Product { get; set; } = null!;
}