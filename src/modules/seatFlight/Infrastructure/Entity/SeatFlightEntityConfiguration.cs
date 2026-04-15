using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaDeGestionDeTicketsAereos.src.modules.flight.Infrastructure.Entity;
using SistemaDeGestionDeTicketsAereos.src.modules.seat.Infrastructure.Entity;

namespace SistemaDeGestionDeTicketsAereos.src.modules.seatFlight.Infrastructure.Entity;

public sealed class SeatFlightEntityConfiguration : IEntityTypeConfiguration<SeatFlightEntity>
{
    public void Configure(EntityTypeBuilder<SeatFlightEntity> builder)
    {
        builder.ToTable("SeatFlight");

        builder.HasKey(x => x.IdSeatFlight);

        builder.Property(x => x.IdSeatFlight)
            .HasColumnName("IdSeatFlight")
            .ValueGeneratedOnAdd();

        builder.Property(x => x.IdSeat)
            .HasColumnName("IdSeat")
            .IsRequired();

        builder.Property(x => x.IdFlight)
            .HasColumnName("IdFlight")
            .IsRequired();

        builder.Property(x => x.Available)
            .HasColumnName("Available")
            .HasColumnType("tinyint(1)")
            .HasDefaultValue(true)
            .IsRequired();

        builder.HasIndex(x => new { x.IdSeat, x.IdFlight })
            .IsUnique()
            .HasDatabaseName("UQ_SeatFlight");

        builder.HasOne<SeatEntity>()
            .WithMany()
            .HasForeignKey(x => x.IdSeat)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne<FlightEntity>()
            .WithMany()
            .HasForeignKey(x => x.IdFlight)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
