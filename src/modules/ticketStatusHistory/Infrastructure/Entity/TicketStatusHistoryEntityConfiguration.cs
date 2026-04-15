using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaDeGestionDeTicketsAereos.src.modules.systemStatus.Infrastructure.Entity;
using SistemaDeGestionDeTicketsAereos.src.modules.ticket.Infrastructure.Entity;
using SistemaDeGestionDeTicketsAereos.src.modules.user.Infrastructure.Entity;

namespace SistemaDeGestionDeTicketsAereos.src.modules.ticketStatusHistory.Infrastructure.Entity;

public sealed class TicketStatusHistoryEntityConfiguration : IEntityTypeConfiguration<TicketStatusHistoryEntity>
{
    public void Configure(EntityTypeBuilder<TicketStatusHistoryEntity> builder)
    {
        builder.ToTable("TicketStatusHistory");

        builder.HasKey(x => x.IdHistory);

        builder.Property(x => x.IdHistory)
            .HasColumnName("IdHistory")
            .ValueGeneratedOnAdd();

        builder.Property(x => x.IdTicket)
            .HasColumnName("IdTicket")
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

        builder.HasOne<TicketEntity>()
            .WithMany()
            .HasForeignKey(x => x.IdTicket)
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
