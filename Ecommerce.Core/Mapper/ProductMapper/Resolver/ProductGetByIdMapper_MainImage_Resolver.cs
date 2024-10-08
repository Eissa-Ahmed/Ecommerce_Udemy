﻿namespace Ecommerce.Application.Mapper.ProductMapper.Resolver;

public sealed class ProductGetByIdMapper_MainImage_Resolver : IValueResolver<Product, ProductGetByIdResult, string>
{
    private readonly IOptions<ApplicationSettingModel> _settings;

    public ProductGetByIdMapper_MainImage_Resolver(IOptions<ApplicationSettingModel> settings)
    {
        _settings = settings;
    }

    public string Resolve(Product source, ProductGetByIdResult destination, string destMember, ResolutionContext context)
    {
        return $"{_settings.Value.ApiUrl}{source.MainImage}";
    }
}

