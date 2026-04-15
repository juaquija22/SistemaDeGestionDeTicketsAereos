using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaDeGestionDeTicketsAereos.src.modules.booking.Infrastructure.Entity;
using SistemaDeGestionDeTicketsAereos.src.modules.person.Infrastructure.Entity;
using SistemaDeGestionDeTicketsAereos.src.modules.seat.Infrastructure.Entity;
using SistemaDeGestionDeTicketsAereos.src.modules.user.Infrastructure.Entity;

namespace SistemaDeGestionDeTicketsAereos.src.modules.bookingCustomer.Infrastructure.Entity;

public sealed class BookingCustomerEntityConfiguration : IEntityTypeConfiguration<BookingCustomerEntity>
{
    public void Configure(EntityTypeBuilder<BookingCustomerEntity> builder)
    {
        builder.ToTable("BookingCustomer");

        builder.HasKey(x => x.IdBookingCustomer);

        builder.Property(x => x.IdBookingCustomer)
            .HasColumnName("IdBookingCustomer")
            .ValueGeneratedOnAdd();

        builder.Property(x => x.IdBooking)
            .HasColumnName("IdBooking")
            .IsRequired();

        builder.Property(x => x.IdUser)
            .HasColumnName("IdUser")
            .IsRequired();

        builder.Property(x => x.IdPerson)
            .HasColumnName("IdPerson")
            .IsRequired();

        builder.Property(x => x.IdSeat)
            .HasColumnName("IdSeat")
            .IsRequired();

        builder.Property(x => x.IsPrimary)
            .HasColumnName("IsPrimary")
            .HasColumnType("tinyint(1)")
            .HasDefaultValue(true)
            .IsRequired();

        builder.Property(x => x.AssociationDate)
            .HasColumnName("AssociationDate")
            .HasColumnType("datetime")
            .HasDefaultValueSql("CURRENT_TIMESTAMP")
            .IsRequired();

        builder.HasOne<BookingEntity>()
            .WithMany()
            .HasForeignKey(x => x.IdBooking)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne<PersonEntity>()
            .WithMany()
            .HasForeignKey(x => x.IdPerson)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne<UserEntity>()
            .WithMany()
            .HasForeignKey(x => x.IdUser)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne<SeatEntity>()
            .WithMany()
            .HasForeignKey(x => x.IdSeat)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
