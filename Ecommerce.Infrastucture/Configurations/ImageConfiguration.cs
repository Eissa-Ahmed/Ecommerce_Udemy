namespace Ecommerce.Infrastucture.Configurations;

public sealed class ImageConfiguration : IEntityTypeConfiguration<Images>
{
    public void Configure(EntityTypeBuilder<Images> entity)
    {
        entity.ToTable(nameof(Images));

        entity.HasKey(k => k.Name);

    }
}
