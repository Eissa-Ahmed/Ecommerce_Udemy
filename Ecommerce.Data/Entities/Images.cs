namespace Ecommerce.Domain.Entities;

public sealed class Images
{
    public Images()
    {
        Id = Guid.NewGuid().ToString();
    }
    public string Id { get; set; } = null!;
    public string Name { get; set; } = null!;
    public double Size { get; set; }
    public string extension => Path.GetExtension(Name);
    public string ProductId { get; set; } = null!;
}