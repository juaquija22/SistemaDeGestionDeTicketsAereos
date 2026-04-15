namespace SistemaDeGestionDeTicketsAereos.src.modules.flightStatusHistory.Infrastructure.Entity;

public class FlightStatusHistoryEntity
{
    public int IdHistory { get; set; }
    public int IdFlight { get; set; }
    public int IdStatus { get; set; }
    public DateTime ChangeDate { get; set; }
    public int IdUser { get; set; }
    public string? Observation { get; set; }
}
