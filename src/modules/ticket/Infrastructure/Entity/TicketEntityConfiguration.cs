using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaDeGestionDeTicketsAereos.src.modules.booking.Infrastructure.Entity;
using SistemaDeGestionDeTicketsAereos.src.modules.fare.Infrastructure.Entity;
using SistemaDeGestionDeTicketsAereos.src.modules.systemStatus.Infrastructure.Entity;

namespace SistemaDeGestionDeTicketsAereos.src.modules.ticket.Infrastructure.Entity;

public sealed class TicketEntityConfiguration : IEntityTypeConfiguration<TicketEntity>
{
    public void Configure(EntityTypeBuilder<TicketEntity> builder)
    {
        builder.ToTable("Ticket");

        builder.HasKey(x => x.IdTicket);

        builder.Property(x => x.IdTicket)
            .HasColumnName("IdTicket")
            .ValueGeneratedOnAdd();

        builder.Property(x => x.TicketCode)
            .HasColumnName("TicketCode")
            .HasColumnType("varchar(20)")
            .IsRequired();

        builder.HasIndex(x => x.TicketCode)
            .IsUnique()
            .HasDatabaseName("UQ_Ticket_Code");

        builder.Property(x => x.IdBooking)
            .HasColumnName("IdBooking")
            .IsRequired();

        builder.Property(x => x.IdFare)
            .HasColumnName("IdFare")
            .IsRequired();

        builder.Property(x => x.IdStatus)
            .HasColumnName("IdStatus")
            .IsRequired();

        builder.Property(x => x.IssueDate)
            .HasColumnName("IssueDate")
            .HasColumnType("datetime")
            .HasDefaultValueSql("CURRENT_TIMESTAMP")
            .IsRequired();

        builder.HasOne<BookingEntity>()
            .WithMany()
            .HasForeignKey(x => x.IdBooking)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne<FareEntity>()
            .WithMany()
            .HasForeignKey(x => x.IdFare)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne<SystemStatusEntity>()
            .WithMany()
            .HasForeignKey(x => x.IdStatus)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
