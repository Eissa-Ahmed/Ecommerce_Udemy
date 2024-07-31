namespace Ecommerce.Infrastucture.Configurations;

public sealed class UserConfiguration : IEntityTypeConfiguration<Users>
{
    public void Configure(EntityTypeBuilder<Users> entity)
    {
        entity.ToTable(nameof(Users));


        entity
            .HasMany(m => m.Favorites)
            .WithOne()
            .HasForeignKey(i => i.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        entity
            .HasMany(m => m.Address)
            .WithOne()
            .HasForeignKey(i => i.UserId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}