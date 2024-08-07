﻿namespace Ecommerce.Domain.Entities;

public sealed class Favorite
{
    public Favorite()
    {
        Id = Guid.NewGuid().ToString();
        CreatedDate = DateTime.UtcNow;
    }
    public string Id { get; set; } = null!;
    public string UserId { get; set; } = null!;
    public string ProductId { get; set; } = null!;
    public Product Product { get; set; } = null!;
    public DateTime CreatedDate { get; set; }
}
