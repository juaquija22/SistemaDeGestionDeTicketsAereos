using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaDeGestionDeTicketsAereos.src.modules.person.Infrastructure.Entity;
using SistemaDeGestionDeTicketsAereos.src.modules.role.Infrastructure.Entity;

namespace SistemaDeGestionDeTicketsAereos.src.modules.user.Infrastructure.Entity;

public sealed class UserEntityConfiguration : IEntityTypeConfiguration<UserEntity>
{
    public void Configure(EntityTypeBuilder<UserEntity> builder)
    {
        builder.ToTable("User");

        builder.HasKey(x => x.IdUser);

        builder.Property(x => x.IdUser)
            .HasColumnName("IdUser")
            .ValueGeneratedOnAdd();

        builder.Property(x => x.Username)
            .HasColumnName("Username")
            .HasColumnType("varchar(60)")
            .IsRequired();

        builder.HasIndex(x => x.Username)
            .IsUnique()
            .HasDatabaseName("UQ_User_Username");

        builder.Property(x => x.Password)
            .HasColumnName("Password")
            .HasColumnType("varchar(255)")
            .IsRequired();

        builder.Property(x => x.IdUserRole)
            .HasColumnName("IdUserRole")
            .IsRequired();

        builder.Property(x => x.IdPerson)
            .HasColumnName("IdPerson");

        builder.Property(x => x.Active)
            .HasColumnName("Active")
            .HasColumnType("tinyint(1)")
            .HasDefaultValue(true)
            .IsRequired();

        builder.HasOne<RoleEntity>()
            .WithMany()
            .HasForeignKey(x => x.IdUserRole)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne<PersonEntity>()
            .WithMany()
            .HasForeignKey(x => x.IdPerson)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
