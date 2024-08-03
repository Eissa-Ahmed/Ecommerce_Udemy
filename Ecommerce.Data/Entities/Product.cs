namespace Ecommerce.Domain.Entities;

public sealed class Product
{
    public Product()
    {
        Id = Guid.NewGuid().ToString();
        CreatedDate = DateTime.UtcNow;
        IsShow = true;
        Images = new List<Images>();
        ProductAttributes = new List<ProductAttributes>();
        Reviews = new List<Review>();
        Ratings = new List<Rating>();
        Favorite = new List<Favorite>();
    }
    public string Id { get; set; }
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string MainImage { get; set; } = null!;
    public int StockQuantity { get; set; }
    public decimal Price { get; set; }
    public int Discount { get; set; }
    public bool IsShow { get; set; }
    public bool FreeShipping { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? UpdatedDate { get; set; } = null;
    public string CategoryId { get; set; } = null!;
    public Category Category { get; set; } = null!;
    public string? BrandId { get; set; } = null;
    public Brand? Brand { get; set; } = null;
    public ICollection<Images> Images { get; set; }
    public ICollection<ProductAttributes> ProductAttributes { get; set; }
    public ICollection<Favorite> Favorite { get; set; }
    public ICollection<Review> Reviews { get; set; }
    public ICollection<Rating> Ratings { get; set; }
}
