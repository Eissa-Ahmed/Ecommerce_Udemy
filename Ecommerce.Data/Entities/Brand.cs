namespace Ecommerce.Domain.Entities;

public sealed class Brand
{
    public Brand()
    {
        Products = new List<Product>();
    }
    public string Name { get; set; } = null!;
    public ICollection<Product> Products { get; set; }
}
