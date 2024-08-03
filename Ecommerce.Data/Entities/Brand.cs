namespace Ecommerce.Domain.Entities;

public sealed class Brand
{
    public Brand()
    {
        Id = Guid.NewGuid().ToString();
        Products = new List<Product>();
    }
    public string Id { get; set; } = null!;
    public string Name { get; set; } = null!;
    public ICollection<Product> Products { get; set; }
}
