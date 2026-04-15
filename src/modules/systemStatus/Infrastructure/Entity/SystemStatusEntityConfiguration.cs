using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SistemaDeGestionDeTicketsAereos.src.modules.systemStatus.Infrastructure.Entity;

public sealed class SystemStatusEntityConfiguration : IEntityTypeConfiguration<SystemStatusEntity>
{
    public void Configure(EntityTypeBuilder<SystemStatusEntity> builder)
    {
        builder.ToTable("SystemStatus");

        builder.HasKey(x => x.IdStatus);

        builder.Property(x => x.IdStatus)
            .HasColumnName("IdStatus")
            .ValueGeneratedOnAdd();

        builder.Property(x => x.StatusName)
            .HasColumnName("StatusName")
            .HasColumnType("varchar(50)")
            .IsRequired();

        builder.Property(x => x.EntityType)
            .HasColumnName("EntityType")
            .HasColumnType("varchar(20)")
            .IsRequired();
    }
}
