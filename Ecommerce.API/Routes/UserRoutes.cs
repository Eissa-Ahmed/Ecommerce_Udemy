namespace Ecommerce.API.Routes;

public static class UserRoutes
{
    private const string Base = "api/v{version:apiVersion}/users";
    public const string GetById = Base + "/{Id}";
    public const string UserSubscription = Base + "/subscription/{Email}";
}

