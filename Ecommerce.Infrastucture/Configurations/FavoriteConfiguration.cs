namespace Ecommerce.Infrastucture.Configurations;

public sealed class FavoriteConfiguration : IEntityTypeConfiguration<Favorite>
{
    public void Configure(EntityTypeBuilder<Favorite> entity)
    {
        entity.ToTable(nameof(Favorite));
        entity.HasKey(k => new { k.ProductId, k.UserId });
    }

}

