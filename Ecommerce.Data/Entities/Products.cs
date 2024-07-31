namespace Ecommerce.Domain.Entities;

public sealed class Products
{
    public Products()
    {
        Id = Guid.NewGuid().ToString();
        CreatedDate = DateTime.UtcNow;
        IsShow = true;
        Images = new List<Images>();
        ProductAttributes = new List<ProductAttributes>();
        Reviews = new List<Review>();
        Ratings = new List<Rating>();
    }
    public string Id { get; set; }
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string MainImage { get; set; } = null!;
    public int StockQuantity { get; set; }
    public decimal Price { get; set; }
    public int Discount { get; set; }
    public bool IsShow { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public string CategoryName { get; set; } = null!;
    public Categories Category { get; set; } = null!;
    public string SubCategoryName { get; set; } = null!;
    public SubCategories SubCategory { get; set; } = null!;
    public string? BrandName { get; set; } = null;
    public Brands? Brand { get; set; } = null;
    public ICollection<Images> Images { get; set; }
    public ICollection<ProductAttributes> ProductAttributes { get; set; }
    public ICollection<Review> Reviews { get; set; }
    public ICollection<Rating> Ratings { get; set; }
}
