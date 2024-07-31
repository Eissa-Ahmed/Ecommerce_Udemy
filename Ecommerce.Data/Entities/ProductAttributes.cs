﻿namespace Ecommerce.Domain.Entities;

public sealed class ProductAttributes
{
    public string ProductId { get; set; } = null!;
    public string AttributeName { get; set; } = null!;
    public string Value { get; set; } = null!;
    public Products Product { get; set; } = null!;
}

