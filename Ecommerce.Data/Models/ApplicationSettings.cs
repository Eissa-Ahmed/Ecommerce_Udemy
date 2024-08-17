namespace Ecommerce.Domain.Models;

public sealed class ApplicationSettings
{
    public string ApiUrl { get; set; } = null!;
    public string UiUrl { get; set; } = null!;
}
