using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaDeGestionDeTicketsAereos.src.modules.person.Infrastructure.Entity;

namespace SistemaDeGestionDeTicketsAereos.src.modules.customer.Infrastructure.Entity;

public sealed class CustomerEntityConfiguration : IEntityTypeConfiguration<CustomerEntity>
{
    public void Configure(EntityTypeBuilder<CustomerEntity> builder)
    {
        builder.ToTable("Customer");

        builder.HasKey(x => x.IdCustomer);

        builder.Property(x => x.IdCustomer)
            .HasColumnName("IdCustomer")
            .ValueGeneratedOnAdd();

        builder.Property(x => x.IdPerson)
            .HasColumnName("IdPerson")
            .IsRequired();

        builder.HasIndex(x => x.IdPerson)
            .IsUnique()
            .HasDatabaseName("UQ_Customer_Person");

        builder.Property(x => x.Active)
            .HasColumnName("Active")
            .HasColumnType("tinyint(1)")
            .HasDefaultValue(true)
            .IsRequired();

        builder.Property(x => x.RegistrationDate)
            .HasColumnName("RegistrationDate")
            .HasColumnType("date")
            .IsRequired();

        builder.HasOne<PersonEntity>()
            .WithMany()
            .HasForeignKey(x => x.IdPerson)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
