namespace SistemaDeGestionDeTicketsAereos.src.modules.seat.Infrastructure.Entity;

public class SeatEntity
{
    public int IdSeat { get; set; }
    public int IdAircraft { get; set; }
    public string Number { get; set; } = string.Empty;
    public int IdClase { get; set; }
}
