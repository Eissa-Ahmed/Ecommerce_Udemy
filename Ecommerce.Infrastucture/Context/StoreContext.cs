namespace Ecommerce.Infrastucture.Context;

public sealed class StoreContext : DbContext
{
    public StoreContext(DbContextOptions options) : base(options)
    {
    }
}
