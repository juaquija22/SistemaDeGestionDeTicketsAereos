using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaDeGestionDeTicketsAereos.src.modules.airport.Infrastructure.Entity;
using SistemaDeGestionDeTicketsAereos.src.modules.timeZone.Infrastructure.Entity;

namespace SistemaDeGestionDeTicketsAereos.src.modules.airportTimeZone.Infrastructure.Entity;

public sealed class AirportTimeZoneEntityConfiguration : IEntityTypeConfiguration<AirportTimeZoneEntity>
{
    public void Configure(EntityTypeBuilder<AirportTimeZoneEntity> builder)
    {
        builder.ToTable("AirportTimeZone");

        builder.HasKey(x => new { x.IdAirport, x.IdTimeZone });

        builder.Property(x => x.IdAirport)
            .HasColumnName("IdAirport")
            .IsRequired();

        builder.Property(x => x.IdTimeZone)
            .HasColumnName("IdTimeZone")
            .IsRequired();

        builder.HasOne<AirportEntity>()
            .WithMany()
            .HasForeignKey(x => x.IdAirport)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne<TimeZoneEntity>()
            .WithMany()
            .HasForeignKey(x => x.IdTimeZone)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
