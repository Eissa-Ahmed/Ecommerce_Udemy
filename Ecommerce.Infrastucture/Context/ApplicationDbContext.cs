namespace Ecommerce.Infrastucture.Context;

public sealed class ApplicationDbContext : IdentityDbContext<User, Role, string>
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Brand> Brands { get; set; }
    public DbSet<Review> Review { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Attributes> Attributes { get; set; }
    public DbSet<ProductAttributes> ProductAttributes { get; set; }
    public DbSet<Images> Images { get; set; }
    public DbSet<CareInstructions> CareInstructions { get; set; }
    public DbSet<Features> Features { get; set; }
    public DbSet<Discount> Discount { get; set; }
    public DbSet<Cart> Cart { get; set; }
    public DbSet<CartItem> CartItem { get; set; }
    public DbSet<Order> Order { get; set; }
    public DbSet<CustomerSupportTicket> CustomerSupportTicket { get; set; }
    public DbSet<OrderItem> OrderItem { get; set; }
    public DbSet<Wishlist> Wishlist { get; set; }
    public DbSet<WishlistItem> WishlistItem { get; set; }
    public DbSet<Notification> Notification { get; set; }
    public DbSet<AuditLog> AuditLog { get; set; }
    public DbSet<Coupon> Coupon { get; set; }
    public DbSet<Payment> Payment { get; set; }
    public DbSet<PaymentMethod> PaymentMethod { get; set; }
    public DbSet<Tag> ProductTag { get; set; }
    public DbSet<ProductTag> ProductTagMapping { get; set; }
    public DbSet<ProductVariant> ProductVariant { get; set; }
    public DbSet<Address> Address { get; set; }
    public ApplicationDbContext(DbContextOptions options) : base(options) { }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
