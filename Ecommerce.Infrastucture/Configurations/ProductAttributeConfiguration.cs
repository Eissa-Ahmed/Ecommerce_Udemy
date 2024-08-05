﻿namespace Ecommerce.Infrastucture.Configurations;

public sealed class ProductAttributeConfiguration : IEntityTypeConfiguration<ProductAttributes>
{
    public void Configure(EntityTypeBuilder<ProductAttributes> entity)
    {
        entity.ToTable(nameof(ProductAttributes));

        entity.HasKey(k => k.Id);
        //entity.HasIndex(i => new { i.ProductId, i.AttributeId }).IsUnique();

        entity.HasOne(m => m.Attributes)
           .WithMany()
           .HasForeignKey(i => i.AttributeId)
           .OnDelete(DeleteBehavior.Cascade);
    }
}
