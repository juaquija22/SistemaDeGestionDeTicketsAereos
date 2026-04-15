using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SistemaDeGestionDeTicketsAereos.src.modules.timeZone.Infrastructure.Entity;

public sealed class TimeZoneEntityConfiguration : IEntityTypeConfiguration<TimeZoneEntity>
{
    public void Configure(EntityTypeBuilder<TimeZoneEntity> builder)
    {
        builder.ToTable("TimeZone");

        builder.HasKey(x => x.IdTimeZone);

        builder.Property(x => x.IdTimeZone)
            .HasColumnName("IdTimeZone")
            .ValueGeneratedOnAdd();

        builder.Property(x => x.Name)
            .HasColumnName("Name")
            .HasColumnType("varchar(100)")
            .IsRequired();

        builder.Property(x => x.UTCOffset)
            .HasColumnName("UTCOffset")
            .HasColumnType("varchar(10)")
            .IsRequired();
    }
}
