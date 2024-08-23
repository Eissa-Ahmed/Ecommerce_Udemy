namespace Ecommerce.Domain.Entities;

public sealed class AppSettings
{
    public AppSettings()
    {
        Id = Guid.NewGuid().ToString();
        SocialMediaAccounts = new SocialMediaAccounts();
    }
    public string Id { get; set; }
    public string Email { get; set; } = null!;
    public string Address { get; set; } = null!;
    public string? PhoneNumber { get; set; } = null;
    public decimal MinimumFreeShipping { get; set; }
    public string SocialMediaAccountsId { get; set; } = null!;
    public SocialMediaAccounts SocialMediaAccounts { get; set; }
}
