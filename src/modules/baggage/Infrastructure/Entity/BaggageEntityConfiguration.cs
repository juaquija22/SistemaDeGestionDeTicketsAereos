using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaDeGestionDeTicketsAereos.src.modules.baggageType.Infrastructure.Entity;
using SistemaDeGestionDeTicketsAereos.src.modules.ticket.Infrastructure.Entity;

namespace SistemaDeGestionDeTicketsAereos.src.modules.baggage.Infrastructure.Entity;

public sealed class BaggageEntityConfiguration : IEntityTypeConfiguration<BaggageEntity>
{
    public void Configure(EntityTypeBuilder<BaggageEntity> builder)
    {
        builder.ToTable("Baggage");

        builder.HasKey(x => x.IdBaggage);

        builder.Property(x => x.IdBaggage)
            .HasColumnName("IdBaggage")
            .ValueGeneratedOnAdd();

        builder.Property(x => x.IdTicket)
            .HasColumnName("IdTicket")
            .IsRequired();

        builder.Property(x => x.IdBaggageType)
            .HasColumnName("IdBaggageType")
            .IsRequired();

        builder.Property(x => x.Weight)
            .HasColumnName("Weight")
            .HasColumnType("decimal(6,2)")
            .IsRequired();

        builder.HasOne<TicketEntity>()
            .WithMany()
            .HasForeignKey(x => x.IdTicket)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne<BaggageTypeEntity>()
            .WithMany()
            .HasForeignKey(x => x.IdBaggageType)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
