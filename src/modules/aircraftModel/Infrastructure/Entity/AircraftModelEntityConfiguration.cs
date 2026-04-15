using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaDeGestionDeTicketsAereos.src.modules.manufacturer.Infrastructure.Entity;

namespace SistemaDeGestionDeTicketsAereos.src.modules.aircraftModel.Infrastructure.Entity;

public sealed class AircraftModelEntityConfiguration : IEntityTypeConfiguration<AircraftModelEntity>
{
    public void Configure(EntityTypeBuilder<AircraftModelEntity> builder)
    {
        builder.ToTable("AircraftModel");

        builder.HasKey(x => x.IdModel);

        builder.Property(x => x.IdModel)
            .HasColumnName("IdModel")
            .ValueGeneratedOnAdd();

        builder.Property(x => x.IdManufacturer)
            .HasColumnName("IdManufacturer")
            .IsRequired();

        builder.Property(x => x.Model)
            .HasColumnName("Model")
            .HasColumnType("varchar(50)")
            .IsRequired();

        builder.HasOne<ManufacturerEntity>()
            .WithMany()
            .HasForeignKey(x => x.IdManufacturer)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
