using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaDeGestionDeTicketsAereos.src.modules.country.Infrastructure.Entity;
using SistemaDeGestionDeTicketsAereos.src.modules.documentType.Infrastructure.Entity;
using SistemaDeGestionDeTicketsAereos.src.modules.gender.Infrastructure.Entity;
using SistemaDeGestionDeTicketsAereos.src.modules.personAddress.Infrastructure.Entity;

namespace SistemaDeGestionDeTicketsAereos.src.modules.person.Infrastructure.Entity;

public sealed class PersonEntityConfiguration : IEntityTypeConfiguration<PersonEntity>
{
    public void Configure(EntityTypeBuilder<PersonEntity> builder)
    {
        builder.ToTable("Person");

        builder.HasKey(x => x.IdPerson);

        builder.Property(x => x.IdPerson)
            .HasColumnName("IdPerson")
            .ValueGeneratedOnAdd();

        builder.Property(x => x.IdDocumentType)
            .HasColumnName("IdDocumentType")
            .IsRequired();

        builder.Property(x => x.DocumentNumber)
            .HasColumnName("DocumentNumber")
            .HasColumnType("varchar(30)")
            .IsRequired();

        builder.Property(x => x.FirstName)
            .HasColumnName("FirstName")
            .HasColumnType("varchar(80)")
            .IsRequired();

        builder.Property(x => x.LastName)
            .HasColumnName("LastName")
            .HasColumnType("varchar(80)")
            .IsRequired();

        builder.Property(x => x.BirthDate)
            .HasColumnName("BirthDate")
            .HasColumnType("date")
            .IsRequired();

        builder.Property(x => x.IdGender)
            .HasColumnName("IdGender")
            .IsRequired();

        builder.Property(x => x.IdCountry)
            .HasColumnName("IdCountry")
            .IsRequired();

        builder.Property(x => x.IdAddress)
            .HasColumnName("IdAddress");

        builder.HasOne<DocumentTypeEntity>()
            .WithMany()
            .HasForeignKey(x => x.IdDocumentType)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne<GenderEntity>()
            .WithMany()
            .HasForeignKey(x => x.IdGender)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne<CountryEntity>()
            .WithMany()
            .HasForeignKey(x => x.IdCountry)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne<PersonAddressEntity>()
            .WithMany()
            .HasForeignKey(x => x.IdAddress)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
