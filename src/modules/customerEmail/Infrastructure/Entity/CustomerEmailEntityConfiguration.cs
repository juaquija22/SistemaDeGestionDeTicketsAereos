using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaDeGestionDeTicketsAereos.src.modules.person.Infrastructure.Entity;

namespace SistemaDeGestionDeTicketsAereos.src.modules.customerEmail.Infrastructure.Entity;

public sealed class CustomerEmailEntityConfiguration : IEntityTypeConfiguration<CustomerEmailEntity>
{
    public void Configure(EntityTypeBuilder<CustomerEmailEntity> builder)
    {
        builder.ToTable("CustomerEmail");

        builder.HasKey(x => x.IdEmail);

        builder.Property(x => x.IdEmail)
            .HasColumnName("IdEmail")
            .ValueGeneratedOnAdd();

        builder.Property(x => x.IdPerson)
            .HasColumnName("IdPerson")
            .IsRequired();

        builder.Property(x => x.Email)
            .HasColumnName("Email")
            .HasColumnType("varchar(150)")
            .IsRequired();

        builder.HasOne<PersonEntity>()
            .WithMany()
            .HasForeignKey(x => x.IdPerson)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
