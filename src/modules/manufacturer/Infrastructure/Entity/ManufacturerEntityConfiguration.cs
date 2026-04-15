using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SistemaDeGestionDeTicketsAereos.src.modules.manufacturer.Infrastructure.Entity;

public sealed class ManufacturerEntityConfiguration : IEntityTypeConfiguration<ManufacturerEntity>
{
    public void Configure(EntityTypeBuilder<ManufacturerEntity> builder)
    {
        builder.ToTable("Manufacturer");

        builder.HasKey(x => x.IdManufacturer);

        builder.Property(x => x.IdManufacturer)
            .HasColumnName("IdManufacturer")
            .ValueGeneratedOnAdd();

        builder.Property(x => x.Name)
            .HasColumnName("Name")
            .HasColumnType("varchar(100)")
            .IsRequired();
    }
}
