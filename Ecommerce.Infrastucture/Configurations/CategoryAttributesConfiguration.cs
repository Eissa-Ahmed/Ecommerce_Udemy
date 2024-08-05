namespace Ecommerce.Infrastucture.Configurations;

public sealed class CategoryAttributesConfiguration : IEntityTypeConfiguration<CategoryAttributes>
{
    public void Configure(EntityTypeBuilder<CategoryAttributes> entity)
    {
        entity.ToTable(nameof(CategoryAttributes));
        entity.HasKey(k => k.Id);
        entity.HasIndex(i => new { i.CategoryId, i.AttributesId }).IsUnique();

    }

}
