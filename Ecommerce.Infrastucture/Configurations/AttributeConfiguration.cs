namespace Ecommerce.Infrastucture.Configurations;

public sealed class AttributeConfiguration : IEntityTypeConfiguration<Attributes>
{
    public void Configure(EntityTypeBuilder<Attributes> entity)
    {
        entity.ToTable(nameof(Attributes));
        entity.HasKey(k => k.Id);

        entity.HasIndex(i => i.Name).IsUnique();


    }

}
