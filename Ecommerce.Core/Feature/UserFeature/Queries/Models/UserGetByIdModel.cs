namespace Ecommerce.Application.Feature.UserFeature.Queries.Models;

public sealed class UserGetByIdModel(string Id) : IRequest<ApplicationResponse<UserGetByIdResult>>
{
    public string Id { get; set; } = Id;
}
