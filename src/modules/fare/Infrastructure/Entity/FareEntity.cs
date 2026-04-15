namespace SistemaDeGestionDeTicketsAereos.src.modules.fare.Infrastructure.Entity;

public class FareEntity
{
    public int IdFare { get; set; }
    public string FareName { get; set; } = string.Empty;
    public decimal BasePrice { get; set; }
    public int IdAirline { get; set; }
    public DateOnly ValidFrom { get; set; }
    public DateOnly ValidTo { get; set; }
    public bool Active { get; set; }
    public DateOnly? ExpirationDate { get; set; }
}
