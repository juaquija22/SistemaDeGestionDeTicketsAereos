using SistemaDeGestionDeTicketsAereos.src.modules.airport.Infrastructure.Entity;

namespace SistemaDeGestionDeTicketsAereos.src.modules.route.Infrastructure.Entity;

public class RouteEntity
{
    public int IdRoute { get; set; }
    public int OriginAirport { get; set; }
    public int DestinationAirport { get; set; }
    public AirportEntity OriginAirportNavigation { get; set; } = null!;
    public AirportEntity DestinationAirportNavigation { get; set; } = null!;
    public decimal DistanceKm { get; set; }
    public TimeOnly EstDuration { get; set; }
    public bool Active { get; set; }
}
