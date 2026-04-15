using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaDeGestionDeTicketsAereos.src.modules.flight.Infrastructure.Entity;
using SistemaDeGestionDeTicketsAereos.src.modules.systemStatus.Infrastructure.Entity;

namespace SistemaDeGestionDeTicketsAereos.src.modules.booking.Infrastructure.Entity;

public sealed class BookingEntityConfiguration : IEntityTypeConfiguration<BookingEntity>
{
    public void Configure(EntityTypeBuilder<BookingEntity> builder)
    {
        builder.ToTable("Booking");

        builder.HasKey(x => x.IdBooking);

        builder.Property(x => x.IdBooking)
            .HasColumnName("IdBooking")
            .ValueGeneratedOnAdd();

        builder.Property(x => x.BookingCode)
            .HasColumnName("BookingCode")
            .HasColumnType("varchar(20)")
            .IsRequired();

        builder.HasIndex(x => x.BookingCode)
            .IsUnique()
            .HasDatabaseName("UQ_Booking_Code");

        builder.Property(x => x.FlightDate)
            .HasColumnName("FlightDate")
            .HasColumnType("datetime")
            .IsRequired();

        builder.Property(x => x.IdStatus)
            .HasColumnName("IdStatus")
            .IsRequired();

        builder.Property(x => x.IdFlight)
            .HasColumnName("IdFlight")
            .IsRequired();

        builder.Property(x => x.SeatCount)
            .HasColumnName("SeatCount")
            .HasDefaultValue(1)
            .IsRequired();

        builder.Property(x => x.CreationDate)
            .HasColumnName("CreationDate")
            .HasColumnType("date")
            .IsRequired();

        builder.Property(x => x.Observations)
            .HasColumnName("Observations")
            .HasColumnType("varchar(255)");

        builder.HasOne<SystemStatusEntity>()
            .WithMany()
            .HasForeignKey(x => x.IdStatus)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne<FlightEntity>()
            .WithMany()
            .HasForeignKey(x => x.IdFlight)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
