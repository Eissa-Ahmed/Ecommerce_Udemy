namespace Ecommerce.API.Routes;

public static class ProductRoutes
{
    private const string Base = "api/v{version:apiVersion}/products";
    public const string GetAll = Base + "/all";
    public const string BestSeller = Base + "/best-seller";
    public const string GetById = Base + "/{Id}";
    public const string Search = Base + "/{Name}";
    public const string Create = Base;
    public const string Update = Base;
    public const string Delete = Base + "/{Id}";
}

