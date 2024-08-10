namespace Ecommerce.Domain.Entities;

public class Attributes
{
    public Attributes()
    {
        Id = Guid.NewGuid().ToString();
    }
    public string Id { get; set; } = null!;
    public string Name { get; set; } = null!;
}

