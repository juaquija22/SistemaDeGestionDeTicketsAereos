using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SistemaDeGestionDeTicketsAereos.src.modules.role.Infrastructure.Entity;

public sealed class RoleEntityConfiguration : IEntityTypeConfiguration<RoleEntity>
{
    public void Configure(EntityTypeBuilder<RoleEntity> builder)
    {
        builder.ToTable("Role");

        builder.HasKey(x => x.IdUserRole);

        builder.Property(x => x.IdUserRole)
            .HasColumnName("IdUserRole")
            .ValueGeneratedOnAdd();

        builder.Property(x => x.RoleName)
            .HasColumnName("RoleName")
            .HasColumnType("varchar(50)")
            .IsRequired();
    }
}
