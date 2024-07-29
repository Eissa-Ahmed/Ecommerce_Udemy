namespace Ecommerce.Infrastucture.Context;

public sealed class ApplicationDbContext : DbContext
{
    public DbSet<Products> Products { get; set; }
    public DbSet<Brands> Brands { get; set; }
    public DbSet<Categories> Categories { get; set; }
    public DbSet<SubCategories> SubCategories { get; set; }
    public DbSet<Attributes> Attributes { get; set; }
    public DbSet<ProductAttributes> ProductAttributes { get; set; }
    public DbSet<Images> Images { get; set; }
    public ApplicationDbContext(DbContextOptions options) : base(options) { }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
