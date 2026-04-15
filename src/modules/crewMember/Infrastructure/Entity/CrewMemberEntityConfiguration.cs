using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaDeGestionDeTicketsAereos.src.modules.crew.Infrastructure.Entity;
using SistemaDeGestionDeTicketsAereos.src.modules.employee.Infrastructure.Entity;
using SistemaDeGestionDeTicketsAereos.src.modules.employeeRole.Infrastructure.Entity;

namespace SistemaDeGestionDeTicketsAereos.src.modules.crewMember.Infrastructure.Entity;

public sealed class CrewMemberEntityConfiguration : IEntityTypeConfiguration<CrewMemberEntity>
{
    public void Configure(EntityTypeBuilder<CrewMemberEntity> builder)
    {
        builder.ToTable("CrewMember");

        builder.HasKey(x => x.IdCrewMember);

        builder.Property(x => x.IdCrewMember)
            .HasColumnName("IdCrewMember")
            .ValueGeneratedOnAdd();

        builder.Property(x => x.IdCrew)
            .HasColumnName("IdCrew")
            .IsRequired();

        builder.Property(x => x.IdEmployee)
            .HasColumnName("IdEmployee")
            .IsRequired();

        builder.Property(x => x.IdRole)
            .HasColumnName("IdRole")
            .IsRequired();

        builder.HasOne<CrewEntity>()
            .WithMany()
            .HasForeignKey(x => x.IdCrew)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne<EmployeeEntity>()
            .WithMany()
            .HasForeignKey(x => x.IdEmployee)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne<EmployeeRoleEntity>()
            .WithMany()
            .HasForeignKey(x => x.IdRole)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
