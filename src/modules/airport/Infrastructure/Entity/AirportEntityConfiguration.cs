using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaDeGestionDeTicketsAereos.src.modules.city.Infrastructure.Entity;

namespace SistemaDeGestionDeTicketsAereos.src.modules.airport.Infrastructure.Entity;

public sealed class AirportEntityConfiguration : IEntityTypeConfiguration<AirportEntity>
{
    public void Configure(EntityTypeBuilder<AirportEntity> builder)
    {
        builder.ToTable("Airport");

        builder.HasKey(x => x.IdAirport);

        builder.Property(x => x.IdAirport)
            .HasColumnName("IdAirport")
            .ValueGeneratedOnAdd();

        builder.Property(x => x.Name)
            .HasColumnName("Name")
            .HasColumnType("varchar(150)")
            .IsRequired();

        builder.Property(x => x.IATACode)
            .HasColumnName("IATACode")
            .HasColumnType("char(3)")
            .IsRequired();

        builder.Property(x => x.IdCity)
            .HasColumnName("IdCity")
            .IsRequired();

        builder.Property(x => x.Active)
            .HasColumnName("Active")
            .HasColumnType("tinyint(1)")
            .HasDefaultValue(true)
            .IsRequired();

        builder.HasIndex(x => x.IATACode)
            .IsUnique()
            .HasDatabaseName("UQ_Airport_IATACode");

        builder.HasOne<CityEntity>()
            .WithMany()
            .HasForeignKey(x => x.IdCity)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
