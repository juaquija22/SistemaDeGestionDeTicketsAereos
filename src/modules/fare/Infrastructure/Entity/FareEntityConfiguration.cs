using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaDeGestionDeTicketsAereos.src.modules.aeroline.Infrastructure.Entity;

namespace SistemaDeGestionDeTicketsAereos.src.modules.fare.Infrastructure.Entity;

public sealed class FareEntityConfiguration : IEntityTypeConfiguration<FareEntity>
{
    public void Configure(EntityTypeBuilder<FareEntity> builder)
    {
        builder.ToTable("Fare");

        builder.HasKey(x => x.IdFare);

        builder.Property(x => x.IdFare)
            .HasColumnName("IdFare")
            .ValueGeneratedOnAdd();

        builder.Property(x => x.FareName)
            .HasColumnName("FareName")
            .HasColumnType("varchar(100)")
            .IsRequired();

        builder.Property(x => x.BasePrice)
            .HasColumnName("BasePrice")
            .HasColumnType("decimal(12,2)")
            .IsRequired();

        builder.Property(x => x.IdAirline)
            .HasColumnName("IdAirline")
            .IsRequired();

        builder.Property(x => x.ValidFrom)
            .HasColumnName("ValidFrom")
            .HasColumnType("date")
            .IsRequired();

        builder.Property(x => x.ValidTo)
            .HasColumnName("ValidTo")
            .HasColumnType("date")
            .IsRequired();

        builder.Property(x => x.Active)
            .HasColumnName("Active")
            .HasColumnType("tinyint(1)")
            .HasDefaultValue(true)
            .IsRequired();

        builder.Property(x => x.ExpirationDate)
            .HasColumnName("ExpirationDate")
            .HasColumnType("date");

        builder.HasOne<AerolineEntity>()
            .WithMany()
            .HasForeignKey(x => x.IdAirline)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
