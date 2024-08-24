namespace Ecommerce.Domain.Entities;

public sealed class SocialMediaAccounts
{
    public SocialMediaAccounts()
    {
        Id = Guid.NewGuid().ToString();
    }
    public string Id { get; set; }
    public string? Facebook { get; set; } = null;
    public string? Tiktok { get; set; } = null;
    public string? LinkedIn { get; set; } = null;
    public string? Instagram { get; set; } = null;
    public string? X { get; set; } = null;
    public string? Youtube { get; set; } = null;
    public ApplicationSettings AppSettings { get; set; } = null!;
}