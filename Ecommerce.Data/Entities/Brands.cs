namespace Ecommerce.Domain.Entities;

public sealed class Brands
{
    public Brands()
    {
        Products = new List<Products>();
    }
    public string Name { get; set; } = null!;
    public ICollection<Products> Products { get; set; }
}
