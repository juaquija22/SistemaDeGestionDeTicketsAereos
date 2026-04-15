using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaDeGestionDeTicketsAereos.src.modules.Aircraft.Infrastructure.Entity;
using SistemaDeGestionDeTicketsAereos.src.modules.crew.Infrastructure.Entity;
using SistemaDeGestionDeTicketsAereos.src.modules.route.Infrastructure.Entity;
using SistemaDeGestionDeTicketsAereos.src.modules.systemStatus.Infrastructure.Entity;

namespace SistemaDeGestionDeTicketsAereos.src.modules.flight.Infrastructure.Entity;

public sealed class FlightEntityConfiguration : IEntityTypeConfiguration<FlightEntity>
{
    public void Configure(EntityTypeBuilder<FlightEntity> builder)
    {
        builder.ToTable("Flight");

        builder.HasKey(x => x.IdFlight);

        builder.Property(x => x.IdFlight)
            .HasColumnName("IdFlight")
            .ValueGeneratedOnAdd();

        builder.Property(x => x.IdRoute)
            .HasColumnName("IdRoute")
            .IsRequired();

        builder.Property(x => x.IdAircraft)
            .HasColumnName("IdAircraft")
            .IsRequired();

        builder.Property(x => x.FlightNumber)
            .HasColumnName("FlightNumber")
            .HasColumnType("varchar(10)")
            .IsRequired();

        builder.Property(x => x.Date)
            .HasColumnName("Date")
            .HasColumnType("date")
            .IsRequired();

        builder.Property(x => x.DepartureTime)
            .HasColumnName("DepartureTime")
            .IsRequired();

        builder.Property(x => x.ArrivalTime)
            .HasColumnName("ArrivalTime")
            .IsRequired();

        builder.Property(x => x.TotalCapacity)
            .HasColumnName("TotalCapacity")
            .IsRequired();

        builder.Property(x => x.AvailableSeats)
            .HasColumnName("AvailableSeats")
            .IsRequired();

        builder.Property(x => x.IdStatus)
            .HasColumnName("IdStatus")
            .IsRequired();

        builder.Property(x => x.IdCrew)
            .HasColumnName("IdCrew")
            .IsRequired();

        builder.HasOne<RouteEntity>()
            .WithMany()
            .HasForeignKey(x => x.IdRoute)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne<AircraftEntity>()
            .WithMany()
            .HasForeignKey(x => x.IdAircraft)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne<SystemStatusEntity>()
            .WithMany()
            .HasForeignKey(x => x.IdStatus)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne<CrewEntity>()
            .WithMany()
            .HasForeignKey(x => x.IdCrew)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
