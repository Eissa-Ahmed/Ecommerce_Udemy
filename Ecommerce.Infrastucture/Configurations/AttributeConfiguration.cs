namespace Ecommerce.Infrastucture.Configurations;

public sealed class AttributeConfiguration : IEntityTypeConfiguration<Attributes>
{
    public void Configure(EntityTypeBuilder<Attributes> entity)
    {
        entity.ToTable(nameof(Attributes));
        entity.HasKey(k => k.Id);

        entity.HasIndex(i => i.Name).IsUnique();

        entity.HasMany(m => m.ProductAttributes)
            .WithOne(o => o.Attributes)
            .HasForeignKey(i => i.AttributeId)
            .OnDelete(DeleteBehavior.Cascade);
    }

}
