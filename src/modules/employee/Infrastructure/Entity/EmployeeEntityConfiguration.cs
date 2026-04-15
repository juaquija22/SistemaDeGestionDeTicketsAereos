using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaDeGestionDeTicketsAereos.src.modules.aeroline.Infrastructure.Entity;
using SistemaDeGestionDeTicketsAereos.src.modules.employeeRole.Infrastructure.Entity;
using SistemaDeGestionDeTicketsAereos.src.modules.person.Infrastructure.Entity;

namespace SistemaDeGestionDeTicketsAereos.src.modules.employee.Infrastructure.Entity;

public sealed class EmployeeEntityConfiguration : IEntityTypeConfiguration<EmployeeEntity>
{
    public void Configure(EntityTypeBuilder<EmployeeEntity> builder)
    {
        builder.ToTable("Employee");

        builder.HasKey(x => x.IdEmployee);

        builder.Property(x => x.IdEmployee)
            .HasColumnName("IdEmployee")
            .ValueGeneratedOnAdd();

        builder.Property(x => x.IdPerson)
            .HasColumnName("IdPerson")
            .IsRequired();

        builder.Property(x => x.IdAirline)
            .HasColumnName("IdAirline")
            .IsRequired();

        builder.Property(x => x.IdRole)
            .HasColumnName("IdRole")
            .IsRequired();

        builder.HasOne<PersonEntity>()
            .WithMany()
            .HasForeignKey(x => x.IdPerson)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne<AerolineEntity>()
            .WithMany()
            .HasForeignKey(x => x.IdAirline)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne<EmployeeRoleEntity>()
            .WithMany()
            .HasForeignKey(x => x.IdRole)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
