namespace Ecommerce.Infrastucture.Configurations;

public sealed class FavoriteConfiguration : IEntityTypeConfiguration<Favorite>
{
    public void Configure(EntityTypeBuilder<Favorite> entity)
    {
        entity.ToTable(nameof(Favorite));
        entity.HasKey(k => k.Id);
        entity.HasIndex(i => new { i.ProductId, i.UserId }).IsUnique();
    }

}

