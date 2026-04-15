using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SistemaDeGestionDeTicketsAereos.src.modules.paymentmethod.Infrastructure.Entity;

public sealed class PaymentMethodEntityConfiguration : IEntityTypeConfiguration<PaymentMethodEntity>
{
    public void Configure(EntityTypeBuilder<PaymentMethodEntity> builder)
    {
        builder.ToTable("PaymentMethod");

        builder.HasKey(x => x.IdPaymentMethod);

        builder.Property(x => x.IdPaymentMethod)
            .HasColumnName("IdPaymentMethod")
            .ValueGeneratedOnAdd();

        builder.Property(x => x.MethodName)
            .HasColumnName("MethodName")
            .HasColumnType("varchar(50)")
            .IsRequired();
    }
}
