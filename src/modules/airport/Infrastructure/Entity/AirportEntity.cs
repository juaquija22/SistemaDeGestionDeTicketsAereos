namespace SistemaDeGestionDeTicketsAereos.src.modules.airport.Infrastructure.Entity;

public class AirportEntity
{
    public int IdAirport { get; set; }
    public string Name { get; set; } = string.Empty;
    public string IATACode { get; set; } = string.Empty;
    public int IdCity { get; set; }
    public bool Active { get; set; }
}
