namespace SistemaDeGestionDeTicketsAereos.src.modules.seatFlight.Infrastructure.Entity;

public class SeatFlightEntity
{
    public int IdSeatFlight { get; set; }
    public int IdSeat { get; set; }
    public int IdFlight { get; set; }
    public bool Available { get; set; }
}
