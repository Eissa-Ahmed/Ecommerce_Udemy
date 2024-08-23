namespace Ecommerce.Infrastucture.Configurations;

public sealed class AppSettingsConfiguration : IEntityTypeConfiguration<ApplicationSettings>
{
    public void Configure(EntityTypeBuilder<ApplicationSettings> entity)
    {
        entity.ToTable(nameof(ApplicationSettings));

        entity.HasKey(k => k.Id);

        entity.Property(p => p.Email)
            .IsRequired();

        entity.Property(p => p.MinimumFreeShipping)
            .HasAnnotation("MinValue", 0);

        entity.HasOne(i => i.SocialMediaAccounts)
            .WithOne(i => i.AppSettings)
            .HasForeignKey<ApplicationSettings>(i => i.SocialMediaAccountsId)
            .OnDelete(DeleteBehavior.Cascade);

    }
}
