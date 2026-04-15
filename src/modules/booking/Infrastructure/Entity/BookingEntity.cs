namespace SistemaDeGestionDeTicketsAereos.src.modules.booking.Infrastructure.Entity;

public class BookingEntity
{
    public int IdBooking { get; set; }
    public string BookingCode { get; set; } = string.Empty;
    public DateTime FlightDate { get; set; }
    public int IdStatus { get; set; }
    public int IdFlight { get; set; }
    public int SeatCount { get; set; }
    public DateOnly CreationDate { get; set; }
    public string? Observations { get; set; }
}
