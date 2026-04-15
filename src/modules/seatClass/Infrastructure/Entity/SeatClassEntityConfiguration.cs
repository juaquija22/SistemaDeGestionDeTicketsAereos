using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SistemaDeGestionDeTicketsAereos.src.modules.seatClass.Infrastructure.Entity;

public sealed class SeatClassEntityConfiguration : IEntityTypeConfiguration<SeatClassEntity>
{
    public void Configure(EntityTypeBuilder<SeatClassEntity> builder)
    {
        builder.ToTable("SeatClass");

        builder.HasKey(x => x.IdClase);

        builder.Property(x => x.IdClase)
            .HasColumnName("IdClase")
            .ValueGeneratedOnAdd();

        builder.Property(x => x.ClassName)
            .HasColumnName("ClassName")
            .HasColumnType("varchar(50)")
            .IsRequired();
    }
}
