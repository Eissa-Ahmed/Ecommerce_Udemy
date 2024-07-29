using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Domain.Entities;

public class Attributes
{
    [Key]

    public string Name { get; set; } = null!;
    public string CategoryName { get; set; } = null!;
    public Categories Categories { get; set; } = null!;
}

