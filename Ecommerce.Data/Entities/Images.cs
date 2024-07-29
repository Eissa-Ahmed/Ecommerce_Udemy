﻿using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Domain.Entities;

public sealed class Images
{
    [Key]
    public string Name { get; set; } = null!;
    public double Size { get; set; }
    public string extension => Path.GetExtension(Name);
    public string ProductId { get; set; } = null!;
    public Products Product { get; set; } = null!;
}