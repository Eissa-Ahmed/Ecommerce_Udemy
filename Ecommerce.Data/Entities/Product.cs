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
        CareInstructions = new List<CareInstructions>();
        Features = new List<Features>();
        ProductVariant = new List<ProductVariant>();
        ProductTag = new List<ProductTag>();
        CartItem = new List<CartItem>();
        OrderItem = new List<OrderItem>();
        Tags = new List<Tag>();
    }
    public string Id { get; set; }
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string MainImage { get; set; } = null!;
    public int StockQuantity { get; set; }
    public decimal? Price { get; set; } = null;
    public bool IsShow { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? UpdatedDate { get; set; } = null;
    public string CategoryId { get; set; } = null!;
    public Category Category { get; set; } = null!;
    public string? BrandId { get; set; } = null;
    public Brand? Brand { get; set; } = null;
    public string? DiscountId { get; set; }
    public Discount? Discount { get; set; } = null;
    public ICollection<Images> Images { get; set; }
    public ICollection<ProductAttributes> ProductAttributes { get; set; }
    public ICollection<Review> Reviews { get; set; }
    public ICollection<ProductTag> ProductTag { get; set; }
    public ICollection<Tag> Tags { get; set; }
    public ICollection<Features> Features { get; set; }
    public ICollection<ProductVariant> ProductVariant { get; set; }
    public ICollection<CareInstructions> CareInstructions { get; set; }
    public ICollection<CartItem> CartItem { get; set; }
    public ICollection<OrderItem> OrderItem { get; set; }
}
