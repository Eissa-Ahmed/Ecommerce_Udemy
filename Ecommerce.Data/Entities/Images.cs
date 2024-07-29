namespace Ecommerce.Data.Entities;

public class Images
{
    public string Name { get; set; } = null!;
    public double Size { get; set; }
    public string extension => Path.GetExtension(Name);
    public string ProductId { get; set; } = null!;
    public Product Product { get; set; } = null!;
}