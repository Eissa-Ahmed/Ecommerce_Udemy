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
        ProductTagMappings = new List<ProductTagMapping>();
        ProductDiscounts = new List<ProductDiscount>();
        CartItem = new List<CartItem>();
        OrderItem = new List<OrderItem>();
        ProductTags = new List<ProductTag>();
        Discounts = new List<Discount>();
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
    public Discount? HighestDiscount => Discounts
        .Where(i => i.IsActive)
        .OrderByDescending(i => i.DiscountPercentage)
        .FirstOrDefault();
    public ICollection<Images> Images { get; set; }
    public ICollection<ProductAttributes> ProductAttributes { get; set; }
    public ICollection<ProductDiscount> ProductDiscounts { get; set; }
    public ICollection<Discount> Discounts { get; set; }
    public ICollection<Review> Reviews { get; set; }
    public ICollection<ProductTagMapping> ProductTagMappings { get; set; }
    public ICollection<ProductTag> ProductTags { get; set; }
    public ICollection<Features> Features { get; set; }
    public ICollection<ProductVariant> ProductVariant { get; set; }
    public ICollection<CareInstructions> CareInstructions { get; set; }
    public ICollection<CartItem> CartItem { get; set; }
    public ICollection<OrderItem> OrderItem { get; set; }
}
