namespace Ecommerce.Application.Feature.UserFeature.Queries.Results;

public sealed class UserGetByIdResult
{
    public UserGetByIdResult()
    {
        Address = new List<UserGetByIdResultAddress>();
    }
    public string Id { get; set; } = null!;
    public string? FirstName { get; set; } = null;
    public string? LastName { get; set; } = null;
    public string Email { get; set; } = null!;
    public string UserName { get; set; } = null!;
    public string PhoneNumber { get; set; } = null!;
    public string? ImageUrl { get; set; }
    public DateTime DateCreated { get; set; }
    public UserGetByIdResultCart Cart { get; set; } = null!;
    public UserGetByIdResultWishlist Wishlist { get; set; } = null!;
    public ICollection<UserGetByIdResultAddress> Address { get; set; }
}

public sealed class UserGetByIdResultCart
{
    public UserGetByIdResultCart()
    {
        CartItems = new List<UserGetByIdResultCart_CartItem>();
    }
    public string Id { get; set; } = null!;
    public string UserId { get; set; } = null!;
    public DateTime DateCreated { get; set; }
    public ICollection<UserGetByIdResultCart_CartItem> CartItems { get; set; }
}
public sealed class UserGetByIdResultCart_CartItem
{
    public string Id { get; set; } = null!;
    public int Quantity { get; set; }
    public string CartId { get; set; } = null!;
    public UserGetByIdResult_Product Product { get; set; } = null!;
}
public sealed class UserGetByIdResultWishlist
{
    public UserGetByIdResultWishlist()
    {
        WishlistItems = new List<UserGetByIdResultWishlist_WishlistItem>();
    }
    public string Id { get; set; } = null!;
    public string UserId { get; set; } = null!;
    public ICollection<UserGetByIdResultWishlist_WishlistItem> WishlistItems { get; set; }
}
public sealed class UserGetByIdResultWishlist_WishlistItem
{
    public string Id { get; set; } = null!;
    public string WishlistId { get; set; } = null!;
    public UserGetByIdResult_Product Product { get; set; } = null!;
}
public sealed class UserGetByIdResult_Product
{
    public string Id { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string MainImage { get; set; } = null!;
    public decimal Price { get; set; }
}
public sealed class UserGetByIdResultAddress
{
    public string Id { get; set; } = null!;
    public string Address1 { get; set; } = null!;
    public string? Address2 { get; set; } = null;
    public string City { get; set; } = null!;
    public string State { get; set; } = null!;
    public string Country { get; set; } = null!;
    public string? ZipCode { get; set; } = null;
    public bool IsDefault { get; set; }
    public string UserId { get; set; } = null!;
}


