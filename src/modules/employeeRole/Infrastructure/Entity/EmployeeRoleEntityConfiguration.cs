using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SistemaDeGestionDeTicketsAereos.src.modules.employeeRole.Infrastructure.Entity;

public sealed class EmployeeRoleEntityConfiguration : IEntityTypeConfiguration<EmployeeRoleEntity>
{
    public void Configure(EntityTypeBuilder<EmployeeRoleEntity> builder)
    {
        builder.ToTable("EmployeeRole");

        builder.HasKey(x => x.IdRole);

        builder.Property(x => x.IdRole)
            .HasColumnName("IdRole")
            .ValueGeneratedOnAdd();

        builder.Property(x => x.RoleName)
            .HasColumnName("RoleName")
            .HasColumnType("varchar(80)")
            .IsRequired();
    }
}
