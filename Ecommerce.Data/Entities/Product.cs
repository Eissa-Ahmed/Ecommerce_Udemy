namespace Ecommerce.Data.Entities;

public class Product
{
    public Product()
    {
        Id = Guid.NewGuid().ToString();
        CreatedDate = DateTime.UtcNow;
        Images = new List<Images>();
    }
    public string Id { get; set; }
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string MainImage { get; set; } = null!;
    public int quantity { get; set; }
    public decimal Price { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public ICollection<Images> Images { get; set; }
}
