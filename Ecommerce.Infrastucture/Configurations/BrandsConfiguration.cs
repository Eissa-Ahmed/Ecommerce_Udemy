namespace Ecommerce.Infrastucture.Configurations;

public sealed class BrandsConfiguration : IEntityTypeConfiguration<Brand>
{
    public void Configure(EntityTypeBuilder<Brand> entity)
    {
        entity.ToTable(nameof(Brand));

        entity.HasKey(k => k.Name);

        entity
            .HasMany(m => m.Products)
            .WithOne(o => o.Brand)
            .HasForeignKey(i => i.BrandName)
            .OnDelete(DeleteBehavior.SetNull);
    }
}
