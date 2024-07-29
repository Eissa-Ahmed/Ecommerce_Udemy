using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Domain.Entities;

public sealed class Brands
{
    [Key]
    public string Name { get; set; } = null!;
}
