namespace Ecommerce.Infrastucture.Configurations;

public sealed class BrandsConfiguration : IEntityTypeConfiguration<Brand>
{
    public void Configure(EntityTypeBuilder<Brand> entity)
    {
        entity.ToTable(nameof(Brand));

        entity.HasKey(k => k.Id);
        entity.HasIndex(i => i.Name).IsUnique();

        entity
            .HasMany(m => m.Products)
            .WithOne(o => o.Brand)
            .HasForeignKey(i => i.BrandId)
            .OnDelete(DeleteBehavior.SetNull);
    }
}
