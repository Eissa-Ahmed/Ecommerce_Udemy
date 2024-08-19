namespace Ecommerce.Infrastucture.Configurations;

public sealed class DiscountConfiguration : IEntityTypeConfiguration<Discount>
{
    public void Configure(EntityTypeBuilder<Discount> entity)
    {
        entity.ToTable(nameof(Discount));

        entity.HasKey(k => k.Id);


        entity.Property(p => p.DiscountName)
            .IsRequired()
            .HasMaxLength(100);

        entity.Property(p => p.DiscountPercentage)
            .HasAnnotation("MinValue", 1.0m)
            .HasAnnotation("MaxValue", 100.0m);

        entity
           .HasMany(m => m.Products)
           .WithOne(o => o.Discount)
           .HasForeignKey(i => i.DiscountId)
           .OnDelete(DeleteBehavior.SetNull);
    }
}
