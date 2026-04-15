using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaDeGestionDeTicketsAereos.src.modules.city.Infrastructure.Entity;
using SistemaDeGestionDeTicketsAereos.src.modules.person.Infrastructure.Entity;

namespace SistemaDeGestionDeTicketsAereos.src.modules.personAddress.Infrastructure.Entity;

public sealed class PersonAddressEntityConfiguration : IEntityTypeConfiguration<PersonAddressEntity>
{
    public void Configure(EntityTypeBuilder<PersonAddressEntity> builder)
    {
        builder.ToTable("PersonAddress");

        builder.HasKey(x => x.IdAddress);

        builder.Property(x => x.IdAddress)
            .HasColumnName("IdAddress")
            .ValueGeneratedOnAdd();

        builder.Property(x => x.IdPerson)
            .HasColumnName("IdPerson")
            .IsRequired();

        builder.Property(x => x.Street)
            .HasColumnName("Street")
            .HasColumnType("varchar(150)")
            .IsRequired();

        builder.Property(x => x.Number)
            .HasColumnName("Number")
            .HasColumnType("varchar(20)")
            .IsRequired();

        builder.Property(x => x.IdCity)
            .HasColumnName("IdCity")
            .IsRequired();

        builder.Property(x => x.ZipCode)
            .HasColumnName("ZipCode")
            .HasColumnType("varchar(20)");

        builder.Property(x => x.Active)
            .HasColumnName("Active")
            .HasColumnType("tinyint(1)")
            .HasDefaultValue(true)
            .IsRequired();

        builder.HasOne<PersonEntity>()
            .WithMany()
            .HasForeignKey(x => x.IdPerson)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne<CityEntity>()
            .WithMany()
            .HasForeignKey(x => x.IdCity)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
