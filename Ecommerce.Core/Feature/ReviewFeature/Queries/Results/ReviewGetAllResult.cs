namespace Ecommerce.Application.Feature.ReviewFeature.Queries.Results;

public sealed class ReviewGetAllResult
{
    public string Id { get; set; } = null!;
    public ReviewGetAllResult_User User { get; set; } = null!;
    public string? Comment { get; set; } = null;
    public int Rating { get; set; }
    public DateTime CreatedDate { get; set; }
}
public sealed class ReviewGetAllResult_User
{
    public string Name { get; set; } = null!;
    public string Emal { get; set; } = null!;
    public string UserImageUrl { get; set; } = null!;
}