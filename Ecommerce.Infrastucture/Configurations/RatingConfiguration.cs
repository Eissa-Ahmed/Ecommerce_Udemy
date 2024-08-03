namespace Ecommerce.Infrastucture.Configurations;

public sealed class RatingConfiguration : IEntityTypeConfiguration<Rating>
{
    public void Configure(EntityTypeBuilder<Rating> entity)
    {
        entity.ToTable(nameof(Rating));

        entity.HasKey(k => k.Id);
        entity.HasIndex(i => new { i.ProductId, i.UserId }).IsUnique();

    }
}
