namespace Ecommerce.Application.Mapper.ProductMapper.Resolver;

public sealed class ProductGetAll_ConvertSortToEnum_Resolver : IValueResolver<ProductGetAllModel, ProductGetAllParams, ProductSort?>
{
    public ProductSort? Resolve(ProductGetAllModel source, ProductGetAllParams destination, ProductSort? destMember, ResolutionContext context)
    {
        if (string.IsNullOrEmpty(source.Sort)) return null;
        return (ProductSort)Enum.Parse(typeof(ProductSort), source.Sort);
    }
}

