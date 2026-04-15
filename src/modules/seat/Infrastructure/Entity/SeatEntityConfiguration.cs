using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaDeGestionDeTicketsAereos.src.modules.Aircraft.Infrastructure.Entity;
using SistemaDeGestionDeTicketsAereos.src.modules.seatClass.Infrastructure.Entity;

namespace SistemaDeGestionDeTicketsAereos.src.modules.seat.Infrastructure.Entity;

public sealed class SeatEntityConfiguration : IEntityTypeConfiguration<SeatEntity>
{
    public void Configure(EntityTypeBuilder<SeatEntity> builder)
    {
        builder.ToTable("Seat");

        builder.HasKey(x => x.IdSeat);

        builder.Property(x => x.IdSeat)
            .HasColumnName("IdSeat")
            .ValueGeneratedOnAdd();

        builder.Property(x => x.IdAircraft)
            .HasColumnName("IdAircraft")
            .IsRequired();

        builder.Property(x => x.Number)
            .HasColumnName("Number")
            .HasColumnType("varchar(5)")
            .IsRequired();

        builder.Property(x => x.IdClase)
            .HasColumnName("IdClase")
            .IsRequired();

        builder.HasOne<AircraftEntity>()
            .WithMany()
            .HasForeignKey(x => x.IdAircraft)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne<SeatClassEntity>()
            .WithMany()
            .HasForeignKey(x => x.IdClase)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
