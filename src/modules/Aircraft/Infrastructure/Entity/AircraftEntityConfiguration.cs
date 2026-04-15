using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaDeGestionDeTicketsAereos.src.modules.aeroline.Infrastructure.Entity;
using SistemaDeGestionDeTicketsAereos.src.modules.aircraftModel.Infrastructure.Entity;

namespace SistemaDeGestionDeTicketsAereos.src.modules.Aircraft.Infrastructure.Entity;

public sealed class AircraftEntityConfiguration : IEntityTypeConfiguration<AircraftEntity>
{
    public void Configure(EntityTypeBuilder<AircraftEntity> builder)
    {
        builder.ToTable("Aircraft");

        builder.HasKey(x => x.IdAircraft);

        builder.Property(x => x.IdAircraft)
            .HasColumnName("IdAircraft")
            .ValueGeneratedOnAdd();

        builder.Property(x => x.IdAirline)
            .HasColumnName("IdAirline")
            .IsRequired();

        builder.Property(x => x.IdModel)
            .HasColumnName("IdModel")
            .IsRequired();

        builder.Property(x => x.Capacity)
            .HasColumnName("Capacity")
            .IsRequired();

        builder.HasOne<AircraftModelEntity>()
            .WithMany()
            .HasForeignKey(x => x.IdModel)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne<AerolineEntity>()
            .WithMany()
            .HasForeignKey(x => x.IdAirline)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
