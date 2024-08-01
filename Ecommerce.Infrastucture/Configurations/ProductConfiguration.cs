﻿namespace Ecommerce.Infrastucture.Configurations;

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
            .HasMaxLength(500);
        entity.Property(p => p.MainImage)
            .IsRequired();
        entity.Property(p => p.StockQuantity)
            .HasAnnotation("MinValue", 1);
        entity.Property(p => p.Price)
            .IsRequired()
            .HasPrecision(8, 2)
            .HasAnnotation("MinValue", 0.01m);

        entity
            .HasOne(o => o.Brand)
            .WithMany(m => m.Products)
            .HasForeignKey(i => i.BrandName)
            .OnDelete(DeleteBehavior.SetNull);

        entity
            .HasMany(m => m.Images)
            .WithOne()
            .HasForeignKey(i => i.ProductId)
            .OnDelete(DeleteBehavior.Cascade);

        entity
            .HasMany(m => m.ProductAttributes)
            .WithOne()
            .HasForeignKey(i => i.ProductId)
            .OnDelete(DeleteBehavior.Cascade);

        entity
            .HasMany(m => m.Ratings)
            .WithOne()
            .HasForeignKey(i => i.ProductId)
            .OnDelete(DeleteBehavior.Cascade);

        entity
            .HasMany(m => m.Reviews)
            .WithOne()
            .HasForeignKey(i => i.ProductId)
            .OnDelete(DeleteBehavior.Cascade);

    }
}
