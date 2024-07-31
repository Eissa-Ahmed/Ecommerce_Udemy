﻿namespace Ecommerce.Domain.Entities;

public class Users : IdentityUser
{
    public Users()
    {
        Favorites = new List<Favorite>();
        Address = new List<Address>();
    }
    public string? FirstName { get; set; } = null;
    public string? LastName { get; set; } = null;
    public string? ImageName { get; set; }

    public ICollection<Favorite> Favorites { get; set; }
    public ICollection<Address> Address { get; set; }
}
