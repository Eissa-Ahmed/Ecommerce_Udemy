namespace Ecommerce.Domain.Entities;

public class ProductTag
{
    public ProductTag()
    {
        Id = Guid.NewGuid().ToString();
    }
    public string Id { get; set; }
    public string TagName { get; set; } = null!;
}