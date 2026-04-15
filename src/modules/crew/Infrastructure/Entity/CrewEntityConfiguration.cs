using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SistemaDeGestionDeTicketsAereos.src.modules.crew.Infrastructure.Entity;

public sealed class CrewEntityConfiguration : IEntityTypeConfiguration<CrewEntity>
{
    public void Configure(EntityTypeBuilder<CrewEntity> builder)
    {
        builder.ToTable("Crew");

        builder.HasKey(x => x.IdCrew);

        builder.Property(x => x.IdCrew)
            .HasColumnName("IdCrew")
            .ValueGeneratedOnAdd();

        builder.Property(x => x.GroupName)
            .HasColumnName("GroupName")
            .HasColumnType("varchar(100)")
            .IsRequired();
    }
}
