using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SistemaDeGestionDeTicketsAereos.src.modules.baggageType.Infrastructure.Entity;

public sealed class BaggageTypeEntityConfiguration : IEntityTypeConfiguration<BaggageTypeEntity>
{
    public void Configure(EntityTypeBuilder<BaggageTypeEntity> builder)
    {
        builder.ToTable("BaggageType");

        builder.HasKey(x => x.IdBaggageType);

        builder.Property(x => x.IdBaggageType)
            .HasColumnName("IdBaggageType")
            .ValueGeneratedOnAdd();

        builder.Property(x => x.TypeName)
            .HasColumnName("TypeName")
            .HasColumnType("varchar(50)")
            .IsRequired();
    }
}
