namespace Ecommerce.Infrastucture.Configurations;

public sealed class CareInstructionsConfiguration : IEntityTypeConfiguration<CareInstructions>
{
    public void Configure(EntityTypeBuilder<CareInstructions> entity)
    {
        entity.ToTable(nameof(CareInstructions));

        entity.HasKey(k => k.Id);

        entity.Property(i => i.Text)
            .IsRequired()
            .HasMaxLength(250);
    }
}
