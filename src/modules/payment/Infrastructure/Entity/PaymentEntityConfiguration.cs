using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaDeGestionDeTicketsAereos.src.modules.booking.Infrastructure.Entity;
using SistemaDeGestionDeTicketsAereos.src.modules.paymentmethod.Infrastructure.Entity;
using SistemaDeGestionDeTicketsAereos.src.modules.systemStatus.Infrastructure.Entity;

namespace SistemaDeGestionDeTicketsAereos.src.modules.payment.Infrastructure.Entity;

public sealed class PaymentEntityConfiguration : IEntityTypeConfiguration<PaymentEntity>
{
    public void Configure(EntityTypeBuilder<PaymentEntity> builder)
    {
        builder.ToTable("Payment");

        builder.HasKey(x => x.IdPayment);

        builder.Property(x => x.IdPayment)
            .HasColumnName("IdPayment")
            .ValueGeneratedOnAdd();

        builder.Property(x => x.IdBooking)
            .HasColumnName("IdBooking")
            .IsRequired();

        builder.Property(x => x.IdPaymentMethod)
            .HasColumnName("IdPaymentMethod")
            .IsRequired();

        builder.Property(x => x.Amount)
            .HasColumnName("Amount")
            .HasColumnType("decimal(12,2)")
            .IsRequired();

        builder.Property(x => x.PaymentDate)
            .HasColumnName("PaymentDate")
            .HasColumnType("datetime")
            .HasDefaultValueSql("CURRENT_TIMESTAMP")
            .IsRequired();

        builder.Property(x => x.IdStatus)
            .HasColumnName("IdStatus")
            .IsRequired();

        builder.HasOne<BookingEntity>()
            .WithMany()
            .HasForeignKey(x => x.IdBooking)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne<PaymentMethodEntity>()
            .WithMany()
            .HasForeignKey(x => x.IdPaymentMethod)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne<SystemStatusEntity>()
            .WithMany()
            .HasForeignKey(x => x.IdStatus)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
