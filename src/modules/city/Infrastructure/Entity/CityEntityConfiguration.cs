using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaDeGestionDeTicketsAereos.src.modules.country.Infrastructure.Entity;

namespace SistemaDeGestionDeTicketsAereos.src.modules.city.Infrastructure.Entity;

public sealed class CityEntityConfiguration : IEntityTypeConfiguration<CityEntity>
{
    public void Configure(EntityTypeBuilder<CityEntity> builder)
    {
        builder.ToTable("City");

        builder.HasKey(x => x.IdCity);

        builder.Property(x => x.IdCity)
            .HasColumnName("IdCity")
            .ValueGeneratedOnAdd();

        builder.Property(x => x.Name)
            .HasColumnName("Name")
            .HasColumnType("varchar(100)")
            .IsRequired();

        builder.Property(x => x.IdCountry)
            .HasColumnName("IdCountry")
            .IsRequired();

        builder.HasOne<CountryEntity>()
            .WithMany()
            .HasForeignKey(x => x.IdCountry)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
