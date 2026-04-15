using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SistemaDeGestionDeTicketsAereos.src.modules.gender.Infrastructure.Entity;

public sealed class GenderEntityConfiguration : IEntityTypeConfiguration<GenderEntity>
{
    public void Configure(EntityTypeBuilder<GenderEntity> builder)
    {
        builder.ToTable("Gender");

        builder.HasKey(x => x.IdGender);

        builder.Property(x => x.IdGender)
            .HasColumnName("IdGender")
            .ValueGeneratedOnAdd();

        builder.Property(x => x.Description)
            .HasColumnName("Description")
            .HasColumnType("varchar(50)")
            .IsRequired();
    }
}
