namespace Ecommerce.Domain.Entities;

public sealed class CareInstructions
{
    public CareInstructions()
    {
        Id = Guid.NewGuid().ToString();
    }
    public string Id { get; set; } = null!;
    public string Text { get; set; } = null!;
    public string ProductId { get; set; } = null!;
    public Product Product { get; set; } = null!;
}
