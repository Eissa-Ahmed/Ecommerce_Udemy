namespace Ecommerce.Infrastucture.Configurations;

public sealed class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> entity)
    {
        entity.ToTable(nameof(Product));
        entity.HasKey(k => k.Id);

        entity.Property(p => p.Name)
            .IsRequired()
            .HasMaxLength(100);

        entity.Property(p => p.Description)
            .IsRequired()
            .HasMaxLength(1000);

        entity.Property(p => p.MainImage)
            .IsRequired();

        entity.Property(p => p.StockQuantity)
            .HasAnnotation("MinValue", 1);

        entity.Property(p => p.Price)
            .HasPrecision(8, 2)
            .HasAnnotation("MinValue", 1.0m);


        entity
            .HasMany(m => m.Images)
            .WithOne()
            .HasForeignKey(i => i.ProductId)
            .OnDelete(DeleteBehavior.Cascade);

        entity
            .HasMany(m => m.ProductAttributes)
            .WithOne(o => o.Product)
            .HasForeignKey(i => i.ProductId)
            .OnDelete(DeleteBehavior.Cascade);


        entity
            .HasMany(m => m.Reviews)
            .WithOne(o => o.Product)
            .HasForeignKey(i => i.ProductId)
            .OnDelete(DeleteBehavior.Cascade);


        entity
            .HasMany(m => m.Features)
            .WithOne(o => o.Product)
            .HasForeignKey(i => i.ProductId)
            .OnDelete(DeleteBehavior.Cascade);

        entity
            .HasMany(m => m.ProductVariant)
            .WithOne(o => o.Product)
            .HasForeignKey(i => i.ProductId)
            .OnDelete(DeleteBehavior.Cascade);

        entity
           .HasMany(m => m.CareInstructions)
           .WithOne(o => o.Product)
           .HasForeignKey(i => i.ProductId)
           .OnDelete(DeleteBehavior.Cascade);

        entity
           .HasMany(m => m.CartItem)
           .WithOne(o => o.Product)
           .HasForeignKey(i => i.ProductId)
           .OnDelete(DeleteBehavior.Cascade);

        entity
           .HasMany(m => m.OrderItem)
           .WithOne(o => o.Product)
           .HasForeignKey(i => i.ProductId)
           .OnDelete(DeleteBehavior.Cascade);

        entity.HasMany(m => m.Tags)
         .WithMany(m => m.Products)
         .UsingEntity<ProductTag>(
            j => j.HasOne(j => j.Tag).WithMany(j => j.ProductTagMappings).HasForeignKey(j => j.TagId),
            i => i.HasOne(i => i.Product).WithMany(i => i.ProductTag).HasForeignKey(i => i.ProductId)
              );


    }
}
