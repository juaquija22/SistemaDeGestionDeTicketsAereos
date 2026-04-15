using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaDeGestionDeTicketsAereos.src.modules.checkinChannel.Infrastructure.Entity;
using SistemaDeGestionDeTicketsAereos.src.modules.seat.Infrastructure.Entity;
using SistemaDeGestionDeTicketsAereos.src.modules.systemStatus.Infrastructure.Entity;
using SistemaDeGestionDeTicketsAereos.src.modules.ticket.Infrastructure.Entity;
using SistemaDeGestionDeTicketsAereos.src.modules.user.Infrastructure.Entity;

namespace SistemaDeGestionDeTicketsAereos.src.modules.CheckIn.Infrastructure.Entity;

public sealed class CheckInEntityConfiguration : IEntityTypeConfiguration<CheckInEntity>
{
    public void Configure(EntityTypeBuilder<CheckInEntity> builder)
    {
        builder.ToTable("CheckIn");

        builder.HasKey(x => x.IdCheckIn);

        builder.Property(x => x.IdCheckIn)
            .HasColumnName("IdCheckIn")
            .ValueGeneratedOnAdd();

        builder.Property(x => x.IdTicket)
            .HasColumnName("IdTicket")
            .IsRequired();

        builder.Property(x => x.CheckInDate)
            .HasColumnName("CheckInDate")
            .HasColumnType("datetime")
            .HasDefaultValueSql("CURRENT_TIMESTAMP")
            .IsRequired();

        builder.Property(x => x.IdChannel)
            .HasColumnName("IdChannel")
            .IsRequired();

        builder.Property(x => x.IdSeat)
            .HasColumnName("IdSeat")
            .IsRequired();

        builder.Property(x => x.IdUser)
            .HasColumnName("IdUser")
            .IsRequired();

        builder.Property(x => x.IdStatus)
            .HasColumnName("IdStatus")
            .IsRequired();

        builder.HasOne<TicketEntity>()
            .WithMany()
            .HasForeignKey(x => x.IdTicket)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne<CheckInChannelEntity>()
            .WithMany()
            .HasForeignKey(x => x.IdChannel)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne<SeatEntity>()
            .WithMany()
            .HasForeignKey(x => x.IdSeat)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne<UserEntity>()
            .WithMany()
            .HasForeignKey(x => x.IdUser)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne<SystemStatusEntity>()
            .WithMany()
            .HasForeignKey(x => x.IdStatus)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
