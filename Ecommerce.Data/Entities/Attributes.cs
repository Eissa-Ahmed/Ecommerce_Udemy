namespace Ecommerce.Domain.Entities;

public class Attributes
{

    public string Name { get; set; } = null!;
    public string CategoryName { get; set; } = null!;
    public Category Category { get; set; } = null!;
}

