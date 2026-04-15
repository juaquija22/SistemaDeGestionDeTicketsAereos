using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SistemaDeGestionDeTicketsAereos.src.modules.country.Infrastructure.Entity;

public sealed class CountryEntityConfiguration : IEntityTypeConfiguration<CountryEntity>
{
    public void Configure(EntityTypeBuilder<CountryEntity> builder)
    {
        builder.ToTable("Country");

        builder.HasKey(x => x.IdCountry);

        builder.Property(x => x.IdCountry)
            .HasColumnName("IdCountry")
            .ValueGeneratedOnAdd();

        builder.Property(x => x.Name)
            .HasColumnName("Name")
            .HasColumnType("varchar(100)")
            .IsRequired();

        builder.Property(x => x.ISOCode)
            .HasColumnName("ISOCode")
            .HasColumnType("char(2)")
            .IsRequired();

        builder.HasIndex(x => x.ISOCode)
            .IsUnique()
            .HasDatabaseName("UQ_Country_ISOCode");
    }
}
