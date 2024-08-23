namespace Ecommerce.Application.Mapper.UserMapper;

public partial class UserProfile
{
    private void ApplyUserGetByIdQuery()
    {
        CreateMap<User, UserGetByIdResult>()
            .ForMember(des => des.Cart, opt => opt.MapFrom(src => src.Cart))
            .ForMember(des => des.Wishlist, opt => opt.MapFrom(src => src.Wishlist))
            .ForMember(des => des.Address, opt => opt.MapFrom(src => src.Address))
            .ForMember(des => des.ImageUrl, opt => opt.MapFrom<UserGetById_ConvertImageNameToImageUrl_Resolver>());

        CreateMap<Cart, UserGetByIdResultCart>()
            .ForMember(des => des.CartItems, opt => opt.MapFrom(src => src.CartItems));

        CreateMap<CartItem, UserGetByIdResultCart_CartItem>()
            .ForMember(des => des.Product, opt => opt.MapFrom<UserGetById_ConvertIdToProduct_Resolver>());


        CreateMap<Wishlist, UserGetByIdResultWishlist>()
            .ForMember(des => des.WishlistItems, opt => opt.MapFrom(src => src.WishlistItems));

        CreateMap<WishlistItem, UserGetByIdResultWishlist_WishlistItem>()
            .ForMember(des => des.Product, opt => opt.MapFrom<UserGetById_ConvertIdToProduct2_Resolver>());

        CreateMap<Address, UserGetByIdResultAddress>();
    }
}
