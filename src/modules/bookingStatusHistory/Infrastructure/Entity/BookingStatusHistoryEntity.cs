namespace SistemaDeGestionDeTicketsAereos.src.modules.bookingStatusHistory.Infrastructure.Entity;

public class BookingStatusHistoryEntity
{
    public int IdHistory { get; set; }
    public int IdBooking { get; set; }
    public int IdStatus { get; set; }
    public DateTime ChangeDate { get; set; }
    public int IdUser { get; set; }
    public string? Observation { get; set; }
}
