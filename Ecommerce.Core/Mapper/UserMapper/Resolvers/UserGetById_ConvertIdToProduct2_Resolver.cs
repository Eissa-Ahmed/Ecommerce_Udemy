namespace Ecommerce.Application.Mapper.UserMapper.Resolvers;

public class UserGetById_ConvertIdToProduct2_Resolver : IValueResolver<WishlistItem, UserGetByIdResultWishlist_WishlistItem, UserGetByIdResult_Product>
{
    private readonly IProductService _productService;

    public UserGetById_ConvertIdToProduct2_Resolver(IProductService productService)
    {
        _productService = productService;
    }

    public UserGetByIdResult_Product Resolve(WishlistItem source, UserGetByIdResultWishlist_WishlistItem destination, UserGetByIdResult_Product destMember, ResolutionContext context)
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