namespace SistemaDeGestionDeTicketsAereos.src.modules.aeroline.Infrastructure.Entity;

public sealed class AerolineEntity
{
    public int IdAirline { get; set; }
    public string Name { get; set; } = string.Empty;
    public string IATACode { get; set; } = string.Empty;
    public int IdCountry { get; set; }
    public bool Active { get; set; }
}
