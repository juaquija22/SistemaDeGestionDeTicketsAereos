namespace SistemaDeGestionDeTicketsAereos.src.modules.bookingCancellation.Infrastructure.Entity;

public class BookingCancellationEntity
{
    public int IdCancellation { get; set; }
    public int IdBooking { get; set; }
    public string CancellationReason { get; set; } = string.Empty;
    public decimal PenaltyAmount { get; set; }
    public DateTime CancellationDate { get; set; }
    public int IdUser { get; set; }
}
