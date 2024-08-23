namespace Ecommerce.Application.Mapper.UserMapper.Resolvers;

public class UserGetById_ConvertIdToProduct_Resolver : IValueResolver<CartItem, UserGetByIdResultCart_CartItem, UserGetByIdResult_Product>
{
    private readonly IProductService _productService;

    public UserGetById_ConvertIdToProduct_Resolver(IProductService productService)
    {
        _productService = productService;
    }

    public UserGetByIdResult_Product Resolve(CartItem source, UserGetByIdResultCart_CartItem destination, UserGetByIdResult_Product destMember, ResolutionContext context)
    {
        Product product = _productService.GetByIdAsync(source.ProductId).Result;

        return new UserGetByIdResult_Product
        {
            Id = product.Id,
            Name = product.Name,
            Price = product.Price ?? 0,
            Description = product.Description,
            MainImage = product.MainImage
        };
    }

}
