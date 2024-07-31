namespace Ecommerce.Infrastucture.Configurations;

public sealed class RatingConfiguration : IEntityTypeConfiguration<Rating>
{
    public void Configure(EntityTypeBuilder<Rating> entity)
    {
        entity.ToTable(nameof(Rating));

        entity.HasKey(k => new { k.ProductId, k.UserId });

    }
}
