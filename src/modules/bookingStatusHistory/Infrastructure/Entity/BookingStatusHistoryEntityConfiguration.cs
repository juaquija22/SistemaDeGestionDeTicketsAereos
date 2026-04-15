using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaDeGestionDeTicketsAereos.src.modules.booking.Infrastructure.Entity;
using SistemaDeGestionDeTicketsAereos.src.modules.systemStatus.Infrastructure.Entity;
using SistemaDeGestionDeTicketsAereos.src.modules.user.Infrastructure.Entity;

namespace SistemaDeGestionDeTicketsAereos.src.modules.bookingStatusHistory.Infrastructure.Entity;

public sealed class BookingStatusHistoryEntityConfiguration : IEntityTypeConfiguration<BookingStatusHistoryEntity>
{
    public void Configure(EntityTypeBuilder<BookingStatusHistoryEntity> builder)
    {
        builder.ToTable("BookingStatusHistory");

        builder.HasKey(x => x.IdHistory);

        builder.Property(x => x.IdHistory)
            .HasColumnName("IdHistory")
            .ValueGeneratedOnAdd();

        builder.Property(x => x.IdBooking)
            .HasColumnName("IdBooking")
            .IsRequired();

        builder.Property(x => x.IdStatus)
            .HasColumnName("IdStatus")
            .IsRequired();

        builder.Property(x => x.ChangeDate)
            .HasColumnName("ChangeDate")
            .HasColumnType("datetime")
            .HasDefaultValueSql("CURRENT_TIMESTAMP")
            .IsRequired();

        builder.Property(x => x.IdUser)
            .HasColumnName("IdUser")
            .IsRequired();

        builder.Property(x => x.Observation)
            .HasColumnName("Observation")
            .HasColumnType("varchar(255)");

        builder.HasOne<BookingEntity>()
            .WithMany()
            .HasForeignKey(x => x.IdBooking)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne<SystemStatusEntity>()
            .WithMany()
            .HasForeignKey(x => x.IdStatus)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne<UserEntity>()
            .WithMany()
            .HasForeignKey(x => x.IdUser)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
