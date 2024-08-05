namespace Ecommerce.Domain.Entities;

public sealed class CategoryAttributes
{
    public CategoryAttributes()
    {
        Id = Guid.NewGuid().ToString();
    }
    public string Id { get; set; } = null!;
    public string CategoryId { get; set; } = null!;
    public Category Category { get; set; } = null!;
    public string AttributesId { get; set; } = null!;
    public Attributes Attributes { get; set; } = null!;
}

