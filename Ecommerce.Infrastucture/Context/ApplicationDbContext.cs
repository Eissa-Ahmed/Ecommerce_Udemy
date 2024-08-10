namespace Ecommerce.Infrastucture.Context;

public sealed class ApplicationDbContext : IdentityDbContext<User>
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Favorite> Favorite { get; set; }
    public DbSet<Brand> Brands { get; set; }
    public DbSet<Review> Review { get; set; }
    public DbSet<Rating> Rating { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Attributes> Attributes { get; set; }
    public DbSet<ProductAttributes> ProductAttributes { get; set; }
    public DbSet<Images> Images { get; set; }
    public DbSet<CareInstructions> CareInstructions { get; set; }
    public DbSet<Features> Features { get; set; }
    public DbSet<ProductColors> ProductColors { get; set; }
    public DbSet<ProductSizes> ProductSizes { get; set; }
    public DbSet<Cart> Cart { get; set; }
    public DbSet<CartItem> CartItem { get; set; }
    public ApplicationDbContext(DbContextOptions options) : base(options) { }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
