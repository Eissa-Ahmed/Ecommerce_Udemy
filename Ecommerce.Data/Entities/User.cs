namespace Ecommerce.Domain.Entities;

public class User : IdentityUser
{
    public User()
    {
        Favorites = new List<Favorite>();
        Address = new List<Address>();
        Rating = new List<Rating>();
        Review = new List<Review>();
    }
    public string? FirstName { get; set; } = null;
    public string? LastName { get; set; } = null;
    public string? ImageName { get; set; }

    public ICollection<Favorite> Favorites { get; set; }
    public ICollection<Address> Address { get; set; }
    public ICollection<Rating> Rating { get; set; }
    public ICollection<Review> Review { get; set; }
}
