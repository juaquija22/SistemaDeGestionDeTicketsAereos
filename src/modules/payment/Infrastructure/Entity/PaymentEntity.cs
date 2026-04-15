namespace SistemaDeGestionDeTicketsAereos.src.modules.payment.Infrastructure.Entity;

public class PaymentEntity
{
    public int IdPayment { get; set; }
    public int IdBooking { get; set; }
    public int IdPaymentMethod { get; set; }
    public decimal Amount { get; set; }
    public DateTime PaymentDate { get; set; }
    public int IdStatus { get; set; }
}
