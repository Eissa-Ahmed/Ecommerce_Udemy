namespace Ecommerce.Application.Feature.ApplicationSettingsFeature.Queries.Results;

public sealed class ApplicationSettingsGetResult
{
    public string Id { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Address { get; set; } = null!;
    public string? PhoneNumber { get; set; } = null;
    public decimal MinimumFreeShipping { get; set; }
    public string SocialMediaAccountsId { get; set; } = null!;
    public ApplicationSettingsGetResult_SocialMediaAccounts SocialMediaAccounts { get; set; } = null!;
}

public sealed class ApplicationSettingsGetResult_SocialMediaAccounts
{
    public string Id { get; set; } = null!;
    public string? Facebook { get; set; } = null;
    public string? Twitter { get; set; } = null;
    public string? Tiktok { get; set; } = null;
    public string? LinkedIn { get; set; } = null;
    public string? Instagram { get; set; } = null;
    public string? X { get; set; } = null;
    public string? Youtube { get; set; } = null;
}
