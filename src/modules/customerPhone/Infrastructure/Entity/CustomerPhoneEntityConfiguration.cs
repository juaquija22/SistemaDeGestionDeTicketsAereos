using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaDeGestionDeTicketsAereos.src.modules.person.Infrastructure.Entity;

namespace SistemaDeGestionDeTicketsAereos.src.modules.customerPhone.Infrastructure.Entity;

public sealed class CustomerPhoneEntityConfiguration : IEntityTypeConfiguration<CustomerPhoneEntity>
{
    public void Configure(EntityTypeBuilder<CustomerPhoneEntity> builder)
    {
        builder.ToTable("CustomerPhone");

        builder.HasKey(x => x.IdPhone);

        builder.Property(x => x.IdPhone)
            .HasColumnName("IdPhone")
            .ValueGeneratedOnAdd();

        builder.Property(x => x.IdPerson)
            .HasColumnName("IdPerson")
            .IsRequired();

        builder.Property(x => x.Phone)
            .HasColumnName("Phone")
            .HasColumnType("varchar(20)")
            .IsRequired();

        builder.HasOne<PersonEntity>()
            .WithMany()
            .HasForeignKey(x => x.IdPerson)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
