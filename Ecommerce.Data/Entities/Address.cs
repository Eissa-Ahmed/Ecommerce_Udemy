namespace Ecommerce.Domain.Entities;

public sealed class Address
{
    public Address()
    {
        Id = Guid.NewGuid().ToString();
    }

    public string Id { get; set; } = null!;
    public string Address1 { get; set; } = null!;
    public string? Address2 { get; set; } = null;
    public string City { get; set; } = null!;
    public string State { get; set; } = null!;
    public string Country { get; set; } = null!;
    public string? ZipCode { get; set; } = null;
    public bool IsDefault { get; set; }
    public string UserId { get; set; } = null!;

}
