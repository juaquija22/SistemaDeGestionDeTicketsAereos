namespace SistemaDeGestionDeTicketsAereos.src.modules.baggage.Infrastructure.Entity;

public class BaggageEntity
{
    public int IdBaggage { get; set; }
    public int IdTicket { get; set; }
    public int IdBaggageType { get; set; }
    public decimal Weight { get; set; }
}
