namespace Ecommerce.Infrastucture.Configurations;

public sealed class BrandsConfiguration : IEntityTypeConfiguration<Brands>
{
    public void Configure(EntityTypeBuilder<Brands> entity)
    {
        entity.ToTable(nameof(Brands));

        entity.HasKey(k => k.Name);

        entity
            .HasMany(m => m.Products)
            .WithOne()
            .HasForeignKey(i => i.BrandName)
            .OnDelete(DeleteBehavior.SetNull);
    }
}
