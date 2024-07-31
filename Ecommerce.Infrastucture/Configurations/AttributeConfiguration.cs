namespace Ecommerce.Infrastucture.Configurations;

public sealed class AttributeConfiguration : IEntityTypeConfiguration<Attributes>
{
    public void Configure(EntityTypeBuilder<Attributes> entity)
    {
        entity.ToTable(nameof(Attributes));
        entity.HasKey(k => k.Name);

        entity
            .HasOne(o => o.SubCategory)
            .WithMany()
            .HasForeignKey(i => i.SubCategoryName)
            .OnDelete(DeleteBehavior.Restrict);
    }

}

