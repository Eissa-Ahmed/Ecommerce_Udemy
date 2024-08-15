namespace Ecommerce.Infrastucture.Configurations;

public sealed class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> entity)
    {
        entity.ToTable(nameof(User));


        entity
            .HasOne(o => o.Cart)
            .WithOne(o => o.User)
            .HasForeignKey<Cart>(i => i.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        entity
            .HasOne(o => o.Wishlist)
            .WithOne(o => o.User)
            .HasForeignKey<Wishlist>(i => i.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        entity
            .HasMany(m => m.Orders)
            .WithOne(o => o.User)
            .HasForeignKey(i => i.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        entity
            .HasMany(m => m.Address)
            .WithOne()
            .HasForeignKey(i => i.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        entity
            .HasMany(m => m.SupportTickets)
            .WithOne(o => o.User)
            .HasForeignKey(i => i.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        entity
            .HasMany(m => m.Review)
            .WithOne(o => o.User)
            .HasForeignKey(i => i.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        entity
            .HasMany(m => m.SupportTickets)
            .WithOne(o => o.User)
            .HasForeignKey(i => i.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        entity
           .HasMany(m => m.AuditLog)
           .WithOne(o => o.User)
           .HasForeignKey(i => i.UserId)
           .OnDelete(DeleteBehavior.Cascade);

        entity
           .HasMany(m => m.Notifications)
           .WithOne(o => o.User)
           .HasForeignKey(i => i.UserId)
           .OnDelete(DeleteBehavior.Cascade);

        entity
           .HasMany(m => m.RefreshToken)
           .WithOne(o => o.User)
           .HasForeignKey(i => i.UserId)
           .OnDelete(DeleteBehavior.Cascade);
    }
}
