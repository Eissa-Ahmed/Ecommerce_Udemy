﻿namespace Ecommerce.API.Routes;

public static class CategoryRoutes
{
    private const string Base = "api/v{version:apiVersion}/categories";
    public const string GetAll = Base;
    public const string GetById = Base + "/{Name}";
    public const string Create = Base;
    public const string Delete = Base + "/{Name}";
}