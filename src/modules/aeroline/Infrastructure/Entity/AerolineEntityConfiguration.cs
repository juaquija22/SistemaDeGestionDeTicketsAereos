using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaDeGestionDeTicketsAereos.src.modules.country.Infrastructure.Entity;

namespace SistemaDeGestionDeTicketsAereos.src.modules.aeroline.Infrastructure.Entity;

public sealed class AerolineEntityConfiguration : IEntityTypeConfiguration<AerolineEntity>
{
    public void Configure(EntityTypeBuilder<AerolineEntity> builder)
    {
        builder.ToTable("Airline");

        builder.HasKey(x => x.IdAirline);

        builder.Property(x => x.IdAirline)
            .HasColumnName("IdAirline")
            .ValueGeneratedOnAdd();

        builder.Property(x => x.Name)
            .HasColumnName("Name")
            .HasColumnType("varchar(150)")
            .IsRequired();

        builder.Property(x => x.IATACode)
            .HasColumnName("IATACode")
            .HasColumnType("char(2)")
            .IsRequired();

        builder.HasIndex(x => x.IATACode)
            .IsUnique()
            .HasDatabaseName("UQ_Airline_IATACode");

        builder.Property(x => x.IdCountry)
            .HasColumnName("IdCountry")
            .IsRequired();

        builder.Property(x => x.Active)
            .HasColumnName("Active")
            .HasColumnType("tinyint(1)")
            .HasDefaultValue(true)
            .IsRequired();

        builder.HasOne<CountryEntity>()
            .WithMany()
            .HasForeignKey(x => x.IdCountry)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
