using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaDeGestionDeTicketsAereos.src.modules.booking.Infrastructure.Entity;
using SistemaDeGestionDeTicketsAereos.src.modules.user.Infrastructure.Entity;

namespace SistemaDeGestionDeTicketsAereos.src.modules.bookingCancellation.Infrastructure.Entity;

public sealed class BookingCancellationEntityConfiguration : IEntityTypeConfiguration<BookingCancellationEntity>
{
    public void Configure(EntityTypeBuilder<BookingCancellationEntity> builder)
    {
        builder.ToTable("BookingCancellation");

        builder.HasKey(x => x.IdCancellation);

        builder.Property(x => x.IdCancellation)
            .HasColumnName("IdCancellation")
            .ValueGeneratedOnAdd();

        builder.Property(x => x.IdBooking)
            .HasColumnName("IdBooking")
            .IsRequired();

        builder.Property(x => x.CancellationReason)
            .HasColumnName("CancellationReason")
            .HasColumnType("varchar(255)")
            .IsRequired();

        builder.Property(x => x.PenaltyAmount)
            .HasColumnName("PenaltyAmount")
            .HasColumnType("decimal(10,2)")
            .HasDefaultValue(0.00m)
            .IsRequired();

        builder.Property(x => x.CancellationDate)
            .HasColumnName("CancellationDate")
            .HasColumnType("datetime")
            .HasDefaultValueSql("CURRENT_TIMESTAMP")
            .IsRequired();

        builder.Property(x => x.IdUser)
            .HasColumnName("IdUser")
            .IsRequired();

        builder.HasOne<BookingEntity>()
            .WithMany()
            .HasForeignKey(x => x.IdBooking)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne<UserEntity>()
            .WithMany()
            .HasForeignKey(x => x.IdUser)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
