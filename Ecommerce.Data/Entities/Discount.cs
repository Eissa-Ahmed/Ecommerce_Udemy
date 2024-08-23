namespace Ecommerce.Domain.Entities;

public sealed class Discount
{
    public Discount()
    {
        Id = Guid.NewGuid().ToString();
        Products = new List<Product>();
    }
    public string Id { get; set; }
    public string DiscountName { get; set; } = null!;
    public string DiscountImageUrl { get; set; } = null!;
    public decimal DiscountPercentage { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public bool IsActive => StartDate.Date < DateTime.UtcNow.Date && EndDate.Date > DateTime.UtcNow.Date;
    public ICollection<Product> Products { get; set; }
}