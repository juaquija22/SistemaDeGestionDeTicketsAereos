namespace SistemaDeGestionDeTicketsAereos.src.modules.flight.Infrastructure.Entity;

public class FlightEntity
{
    public int IdFlight { get; set; }
    public int IdRoute { get; set; }
    public int IdAircraft { get; set; }
    public string FlightNumber { get; set; } = string.Empty;
    public DateOnly Date { get; set; }
    public TimeOnly DepartureTime { get; set; }
    public TimeOnly ArrivalTime { get; set; }
    public int TotalCapacity { get; set; }
    public int AvailableSeats { get; set; }
    public int IdStatus { get; set; }
    public int IdCrew { get; set; }
}
